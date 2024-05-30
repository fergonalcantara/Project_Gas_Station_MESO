#include <ArduinoJson.h>

const int motorAneg = 7;
const int motorApos = 6;
const int motorBneg = 5;
const int motorBpos = 4;
const int ledIndicadorBombaAred = 3;
const int ledIndicadorBombaAgreen = 2;
const int ledIndicadorBombaBred = 26;
const int ledIndicadorBombaBgreen = 27;
const int activarBombaUno = 22;
const int activarBombaDos = 23;
const int activarBombasSimultaneas = 24;
int tiempoServicio = 700;

//Agregado Ultrasonico
int Trig = 50;
int Echo = 51;
long Duracion;
int Distancia;
//Agregado Ultrasonico
// Agregado Sensor de humedad
int sensorTanqueLleno = A0;
int ledIndicador = 13;
bool interrupcionActivada = false;
int indicadorLedSuministroBajo = 30;
int indicadorLedBombaLlena = 8;
// Agregado Sensor de humedad

void controlarBombaTemporizado(int motorPos, int motorNeg, int ledVerde, int ledRojo, int tiempoServicio) {
  digitalWrite(motorNeg, LOW);
  digitalWrite(motorPos, HIGH);
  digitalWrite(ledVerde, HIGH);
  digitalWrite(ledRojo, LOW);
  delay(tiempoServicio);
  detenerBomba(motorPos, motorNeg, ledVerde, ledRojo);
}

void controlarBombaContinua(int motorPos, int motorNeg, int ledVerde, int ledRojo){
  digitalWrite(motorNeg, LOW);
  digitalWrite(motorPos, HIGH);
  digitalWrite(ledVerde, HIGH);
  digitalWrite(ledRojo, LOW);
}

void detenerBomba(int motorPos, int motorNeg, int ledVerde, int ledRojo) {
  digitalWrite(motorNeg, LOW);
  digitalWrite(motorPos, LOW);
  digitalWrite(ledVerde, LOW);
  digitalWrite(ledRojo, HIGH);
}

void reiniciarValores() {
  detenerBomba(motorApos, motorAneg, ledIndicadorBombaAgreen, ledIndicadorBombaAred);
  detenerBomba(motorBpos, motorBneg, ledIndicadorBombaBgreen, ledIndicadorBombaBred);
  digitalWrite(ledIndicadorBombaAred, HIGH);
  digitalWrite(ledIndicadorBombaBred, HIGH);
  digitalWrite(indicadorLedBombaLlena,LOW);
}

void setup() {
  Serial.begin(9600);

  pinMode(motorAneg, OUTPUT);
  pinMode(motorApos, OUTPUT);
  pinMode(motorBneg, OUTPUT);
  pinMode(motorBpos, OUTPUT);
  pinMode(ledIndicadorBombaAred, OUTPUT);
  pinMode(ledIndicadorBombaAgreen, OUTPUT);
  pinMode(ledIndicadorBombaBred, OUTPUT);
  pinMode(ledIndicadorBombaBgreen, OUTPUT);
  pinMode(activarBombaUno, INPUT);
  pinMode(activarBombaDos, INPUT);
  pinMode(activarBombasSimultaneas, INPUT);
  pinMode(Trig, OUTPUT);
  pinMode(Echo, INPUT);
  pinMode(indicadorLedSuministroBajo,OUTPUT);
  pinMode(indicadorLedBombaLlena,OUTPUT);

  reiniciarValores();
}

void loop() {
  if (Serial.available() > 0) {
    String jsonString = Serial.readStringUntil('\n');
    Serial.println(jsonString);

    StaticJsonDocument<200> doc;
    DeserializationError error = deserializeJson(doc, jsonString);

    if (error) {
      Serial.println("Error de deserialización");
      return;
    }
    // Agregado Sensor de humedad
    int lecturaSensor = analogRead(sensorTanqueLleno);
    Serial.println(lecturaSensor);
    delay(1000);
    // Agregado Sensor de humedad
    reiniciarValores();

    const char* idBomba = doc["idBomba"];
    const char* tipoDespacho = doc["tipoDespacho"];
    const char* command = doc["command"];
    int duracion = doc["duracion"];

    if (strcmp(idBomba, "1") == 0) {
      if (strcmp(tipoDespacho, "Cantidad") == 0) {
        if (strcmp(command, "ON") == 0) {
          controlarBombaTemporizado(motorApos, motorAneg, ledIndicadorBombaAgreen, ledIndicadorBombaAred, duracion);
        }
      }else if((strcmp(tipoDespacho, "Tanque Lleno") == 0)){
          controlarBombaContinua(motorApos, motorAneg, ledIndicadorBombaAgreen, ledIndicadorBombaAred);
      }
    } else if ((strcmp(idBomba, "2") == 0)) {
      if (strcmp(tipoDespacho, "Cantidad") == 0) {
        if (strcmp(command, "ON") == 0) {
          controlarBombaTemporizado(motorBpos, motorBneg, ledIndicadorBombaBgreen, ledIndicadorBombaBred, duracion);
        }
      }else if ((strcmp(tipoDespacho, "Tanque Lleno") == 0)){
        unsigned long startMillis = millis();  
        while (digitalRead(sensorTanqueLleno) != HIGH) {
          controlarBombaContinua(motorBpos, motorBneg, ledIndicadorBombaBgreen, ledIndicadorBombaBred);
        }
        unsigned long endMillis = millis();  
        unsigned long durationMillis = endMillis - startMillis;  

        digitalWrite(indicadorLedBombaLlena, HIGH);
        detenerBomba(motorBpos, motorBneg, ledIndicadorBombaBgreen, ledIndicadorBombaBred);

        StaticJsonDocument<200> responseDoc;
        responseDoc["idBomba"] = "2";
        responseDoc["durationMillis"] = durationMillis;

        String responseString;
        serializeJson(responseDoc, responseString);
        Serial.println(responseString);
      }
    }
  }
}