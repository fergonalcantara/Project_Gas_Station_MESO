using Project_Gas_Station.ArduinoComunication;
using Project_Gas_Station.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Gas_Station.GUI
{
    public partial class AdminForm : Form
    {
        private Gasolinera totoGas;
        private ControladorSerial controladorBomba;
        public const double litroPorMinuto = 120.00;
        public AdminForm()
        {
            InitializeComponent();
            InicializarControlBomba();
            LeerArchivo();
            this.totoGas = new Gasolinera();
        }

        private void InicializarControlBomba()
        {
            try
            {
                controladorBomba = new ControladorSerial("COM7", 9600);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el puerto serial: {ex.Message}");
            }
        }

        private void buttonDispensarBomba1_Click(object sender, EventArgs e)
        {
            int idBomba = 1;
            double cantidadLitros = Convert.ToDouble(textBoxCantidadBomba1.Text) / Convert.ToDouble(textBoxPrecioDelDia.Text);
            double precioDelDia = Convert.ToDouble(textBoxPrecioDelDia.Text);
            MessageBox.Show(Convert.ToString(cantidadLitros));

            double tiempoEnMinutos = cantidadLitros / litroPorMinuto;
            int duracionDeLlenado = (int)(tiempoEnMinutos * 60 * 1000);
            MessageBox.Show(Convert.ToString(duracionDeLlenado));
            controladorBomba.SendCommand("ON", duracionDeLlenado);


            totoGas.Abastecimientos.Add(totoGas.Bombas[0], cantidadLitros, precioDelDia, comboBox1.Text,);
            //progressBar1.Minimum = 0;
            //progressBar1.Maximum = duracionDeLlenado;
            //progressBar1.Value = 0;


            //for (int i = 0; i <= duracionDeLlenado; i++)
            //{
            //    await Task.Delay(50); 
            //    progressBar1.Value = i;
            //}
        }

        private void buttonDispensarBomba2_Click(object sender, EventArgs e)
        {
            int idBomba = 2;

        }

        private void buttonDispensarBomba3_Click(object sender, EventArgs e)
        {
            int idBomba = 3;
        }

        private void buttonDispensarBomba4_Click(object sender, EventArgs e)
        {
            int idBomba = 4;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controladorBomba.Dispose();
            FormMenuPrincipal principal = new FormMenuPrincipal();
            principal.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                textBoxCantidadBomba1.Enabled = false;
            }
            else
            {
                textBoxCantidadBomba1.Enabled = true;
            }
        }

        private void comboBoxSeleccionarBomba_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxSeleccionarBomba.SelectedIndex)
            {
                case 0:
                    panelBomba1.Enabled = true;
                    panelBomba2.Enabled = false;
                    panelBomba3.Enabled = false;
                    panelBomba4.Enabled = false;
                    break;
                case 1:
                    panelBomba1.Enabled = false;
                    panelBomba2.Enabled = true;
                    panelBomba3.Enabled = false;
                    panelBomba4.Enabled = false;
                    break;
                case 2:
                    panelBomba1.Enabled = false;
                    panelBomba2.Enabled = false;
                    panelBomba3.Enabled = true;
                    panelBomba4.Enabled = false;
                    break;
                case 3:
                    panelBomba1.Enabled = false;
                    panelBomba2.Enabled = false;
                    panelBomba3.Enabled = false;
                    panelBomba4.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Selecciona la Bomba a habilitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void LeerArchivo()
        {
            string nombrearchivo = "abastecimientos.txt";
            FileStream archivo = new FileStream(nombrearchivo, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader LeerArchivo = new StreamReader(archivo);

            string linea;
            totoGas.Abastecimientos.Clear();
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
                totoGas.Abastecimientos.Add(p);
            }
            LeerArchivo.Close();
            //CargarPersonas(); 
        }

        private void ActualizarArchivo()
        {
            string nombrearchivo = "abastecimientos.txt";

            FileStream archivo = new FileStream(nombrearchivo, FileMode.Create, FileAccess.Write);
            StreamWriter EscribirArchivo = new StreamWriter(archivo);

            foreach (Abastecimiento abastecimiento in totoGas.Abastecimientos)// 
            {
                string linea = abastecimiento.IdBomba + ";" + abastecimiento.FechaHora + ";" + abastecimiento.Cantidad + ";" + abastecimiento.PrecioPorLitro + ";" + abastecimiento.TipoDespacho + ";" + abastecimiento.NombreCliente + ";";
                EscribirArchivo.WriteLine(linea);
            }
            EscribirArchivo.Close();
        }

        
    }
}
