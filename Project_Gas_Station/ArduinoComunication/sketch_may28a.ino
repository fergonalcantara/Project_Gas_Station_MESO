#include <ArduinoJson.h>

const int ledPin = 13; 

void setup() {
  pinMode(ledPin, OUTPUT);
  Serial.begin(9600);
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

    const char* command = doc["command"];
    int duration = doc["duracion"];

    if (strcmp(command, "ON") == 0) {
      digitalWrite(ledPin, HIGH);
      delay(duration);
      digitalWrite(ledPin, LOW);
    }
  }
}

