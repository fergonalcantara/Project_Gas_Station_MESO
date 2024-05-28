using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Gas_Station.Clases
{
    internal class Abastecimiento
    {
        private int idBomba;
        private DateTime fechaHora;
        private double cantidad;
        private double precioPorLitro;
        private string tipoDespacho;
        private string nombreCliente;

        public int IdBomba { get => idBomba; set => idBomba = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioPorLitro { get => precioPorLitro; set => precioPorLitro = value; }
        public string EsPrepago { get => tipoDespacho; set => tipoDespacho = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }

        public Abastecimiento(int idBomba, double cantidad, double precioPorLitro, string tipoDespacho, string nombreCliente)
        {
            this.IdBomba = idBomba;
            this.FechaHora = DateTime.Now;
            this.Cantidad = cantidad;
            this.PrecioPorLitro = precioPorLitro;
            this.EsPrepago = tipoDespacho;
            this.NombreCliente = nombreCliente;
        }
    }
}
