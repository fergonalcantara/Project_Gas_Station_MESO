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
        private double cantidadDispensada;
        public Bomba(int id)
        {
            this.id = id;
            this.cantidadDispensada = 0.0;
        }

        public int Id { get => id; set => id = value; }
        public double CantidadDispensada { get => cantidadDispensada; set => cantidadDispensada = value; }
    }
}
