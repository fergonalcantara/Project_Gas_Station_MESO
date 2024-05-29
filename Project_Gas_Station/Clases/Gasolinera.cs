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
        private List<Bomba> bombas;
        private List<Abastecimiento> abastecimientos;
        private double precioPorLitro;

        public Gasolinera()
        {
            this.bombas = new List<Bomba>();
            for (int i = 0; i < 4; i++)
            {
                Bombas.Add(new Bomba(i + 1));
            }
            this.precioPorLitro = 0.0;
            this.abastecimientos = new List<Abastecimiento>();
        }

        public List<Bomba> Bombas { get => bombas; set => bombas = value; }
        public List<Abastecimiento> Abastecimientos { get => abastecimientos; set => abastecimientos = value; }
        public double PrecioPorLitro1 { get => precioPorLitro; set => precioPorLitro = value; }

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
