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

        public ControladorSerial()
        {
            InicializarControlBomba();
        }

        private void InicializarControlBomba()
        {
            try
            {
                this.serialPort = new SerialPort("COM7", 9600);
                serialPort.Open();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto serial: {ex.Message}");
            }
        }

        public void SendCommand(string idBomba, string tipoDespacho, string command, int duracion)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                var json = JsonSerializer.Serialize(new { idBomba, tipoDespacho, command, duracion });
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
