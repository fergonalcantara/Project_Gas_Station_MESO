using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.Json;

namespace Project_Gas_Station.ArduinoComunication
{
    internal class ControladorSerial:IDisposable
    {
        private SerialPort serialPort;

        public ControladorSerial(string puertoN, int baudRate)
        {
            serialPort = new SerialPort(puertoN, baudRate);
            serialPort.Open();
            Thread.Sleep(2000);
        }

        public void SendCommand(string command, int duracion)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                var json = JsonSerializer.Serialize(new { command, duracion });
                serialPort.WriteLine(json);
                serialPort.BaseStream.Flush(); 
            }
            else
            {
                throw new InvalidOperationException("El puerto serial no está abierto.");
            }
        }

        public void Dispose()
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
