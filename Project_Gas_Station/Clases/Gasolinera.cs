using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Project_Gas_Station.Clases
{
    internal class Gasolinera
    {
        public List<Bomba> Bombas { get; set; } = new List<Bomba>();
        public List<Abastecimiento> Abastecimientos { get; set; } = new List<Abastecimiento>();
        public int PrecioPorLitro { get; set; }

        public Gasolinera()
        {
            for (int i = 0; i < 4; i++)
            {
                Bombas.Add(new Bomba(i + 1));
            }
        }
    }
}
