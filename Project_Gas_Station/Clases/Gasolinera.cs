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
        public double PrecioPorLitro { get; set; }

        public Gasolinera()
        {
            for (int i = 0; i < 4; i++)
            {
                Bombas.Add(new Bomba(i + 1));
            }
            this.PrecioPorLitro = 0.0;
        }

        public void IniciarAbastecimiento(int idBomba, double cantidad, bool esPrepago)
        {
            var bomba = Bombas.FirstOrDefault(b => b.Id == idBomba);
            if (bomba != null)
            {
                bomba.IniciarAbastecimiento(cantidad, esPrepago);
            }
        }

        public void DetenerAbastecimiento(int idBomba)
        {
            var bomba = Bombas.FirstOrDefault(b => b.Id == idBomba);
            bomba?.DetenerAbastecimiento();
        }

        public void RegistrarTransaccion(Abastecimiento abastecimiento)
        {
            Abastecimientos.Add(abastecimiento);
        }
    }
}
