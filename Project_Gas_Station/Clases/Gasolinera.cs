using Project_Gas_Station.GUI;
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

        public void LeerArchivo()
        {
            string nombrearchivo = "abastecimientos.txt";
            FileStream archivo = new FileStream(nombrearchivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LeerArchivo = new StreamReader(archivo);

            string linea;
            Abastecimientos.Clear();
            while ((linea = LeerArchivo.ReadLine()) != null)
            {
                string[] cadena = linea.Split(';');
                int cont = 0;
                Abastecimiento p = new Abastecimiento();

                foreach (string subcadena in cadena)
                {
                    if (cont == 0) { p.IdBomba = Convert.ToInt32(subcadena); }
                    if (cont == 1) { p.FechaHora = Convert.ToDateTime(subcadena); }
                    if (cont == 2) { p.Cantidad = Convert.ToDouble(subcadena); }
                    if (cont == 3) { p.PrecioPorLitro = Convert.ToDouble(subcadena); }
                    if (cont == 4) { p.TipoDespacho = subcadena; }
                    if (cont == 5) { p.NombreCliente = subcadena; }
                    cont++;
                }
                Abastecimientos.Add(p);
            }
            LeerArchivo.Close();
        }

        public void EscribirArchivo(int idBomba, DateTime fechaHora, double cantidadLitros, double precioDelDia, string tipoDespacho,string nombreCliente)
        {
            string nombreArchivo = "abastecimientos.txt";
            FileStream archivo = new FileStream(nombreArchivo, FileMode.Append, FileAccess.Write);
            StreamWriter EscribirArchivo = new StreamWriter(archivo);
            string linea = idBomba + ";" + fechaHora + ";" + cantidadLitros + ";" + precioDelDia + ";" + tipoDespacho + ";" + nombreCliente;
            EscribirArchivo.WriteLine(linea);
            EscribirArchivo.Close();
        }
    }
}
