using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Project_Gas_Station.ArduinoComunication
{
    internal class JsonHandler
    {
        public int GetDurationFromJson(string jsonString)
        {
            try
            {
                var jsonDoc = JsonDocument.Parse(jsonString);
                var root = jsonDoc.RootElement;

                int duracion = root.GetProperty("durationMillis").GetInt32();
                return duracion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al deserializar el JSON: " + ex.Message);
                return -1; 
            }
        }
    }
}
