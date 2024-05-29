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
        public Bomba(int id)
        {
            this.id = id;
            this.estaOcupada = false;
            this.cantidadDispensada = 0.0;
        }

        public int Id { get => id; set => id = value; }
        public bool EstaOcupada { get => estaOcupada; set => estaOcupada = value; }
        public double CantidadDispensada { get => cantidadDispensada; set => cantidadDispensada = value; }

        public void IniciarAbastecimiento(double cantidad, bool esPrepago)
        {
            EstaOcupada = true;
            CantidadDispensada = cantidad;
        }

        public void DetenerAbastecimiento()
        {
            EstaOcupada = false;
        }
}
