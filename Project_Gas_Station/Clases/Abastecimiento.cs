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
        private string fecha;
        private double cantidad;
        private double precioPorLitro;
        private string tipoDespacho;
        private string nombreCliente;

        public int IdBomba { get => idBomba; set => idBomba = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }
        public double PrecioPorLitro { get => precioPorLitro; set => precioPorLitro = value; }
        public string TipoDespacho { get => tipoDespacho; set => tipoDespacho = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }

        public Abastecimiento(int idBomba, string fecha, double cantidad, double precioPorLitro, string tipoDespacho, string nombreCliente)
        {
            this.IdBomba = idBomba;
            this.Fecha = fecha;
            this.Cantidad = cantidad;
            this.PrecioPorLitro = precioPorLitro;
            this.TipoDespacho = tipoDespacho;
            this.NombreCliente = nombreCliente;
        }

        public Abastecimiento() 
        {
            IdBomba = 0;
            Cantidad = 0;
            PrecioPorLitro = 0;
            TipoDespacho = string.Empty;
            NombreCliente = string.Empty;
        }
    }
}
