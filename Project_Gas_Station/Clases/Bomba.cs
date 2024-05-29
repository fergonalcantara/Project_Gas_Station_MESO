using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Gas_Station.Clases
{
    internal class Bomba
    {
        private int id;
        private bool estaOcupada;
        private double cantidadDispensada;
        private List<Abastecimiento> abastecimientos;
        public Bomba(int id)
        {
            this.id = id;
            this.estaOcupada = false;
            this.cantidadDispensada = 0.0;
            this.abastecimientos = new List<Abastecimiento>();
        }

        public int Id { get => id; set => id = value; }
        public bool EstaOcupada { get => estaOcupada; set => estaOcupada = value; }
        public double CantidadDispensada { get => cantidadDispensada; set => cantidadDispensada = value; }
        internal List<Abastecimiento> Abastecimientos { get => abastecimientos; set => abastecimientos = value; }

        public void IniciarAbastecimiento(double cantidad, bool esPrepago)
        {
            EstaOcupada = true;
            CantidadDispensada = cantidad;
        }

        public void DetenerAbastecimiento()
        {
            EstaOcupada = false;
        }

        public void IniciarAbastecimiento(int idBomba, double cantidad, bool esPrepago)
        {

        }

        public void DetenerAbastecimiento(int idBomba)
        {

        }

        public void RegistrarTransaccion(Abastecimiento abastecimiento)
        {
            Abastecimientos.Add(abastecimiento);
        }
    }
}
