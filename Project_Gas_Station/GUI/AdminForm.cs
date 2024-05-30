using Project_Gas_Station.ArduinoComunication;
using Project_Gas_Station.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_Gas_Station.GUI
{
    public partial class AdminForm : Form
    {
        private Gasolinera totoGas;
        private ControladorSerial controladorBombas;
        public const double litroPorMinuto = 120.00;
        public AdminForm()
        {
            InitializeComponent();
            this.totoGas = new Gasolinera();
            totoGas.LeerArchivo();
            this.controladorBombas = new ControladorSerial();
        }

        private void buttonDispensarBomba1_Click(object sender, EventArgs e)
        {
            int idBomba = totoGas.Bombas[0].Id;
            DateTime fechaHora = DateTime.Now.Date;
            double cantidadLitros = Convert.ToDouble(textBoxCantidadBomba1.Text) / Convert.ToDouble(textBoxPrecioDelDia.Text);
            double precioDelDia = Convert.ToDouble(textBoxPrecioDelDia.Text);
            string tipoDespacho = Convert.ToString(comboBoxTipoDespachoBomba1.Text);
            string nombreCliente = textBoxNombreCliente.Text;

            Abastecimiento abastecimiento = new Abastecimiento(idBomba, fechaHora,cantidadLitros,precioDelDia,tipoDespacho,nombreCliente);
            totoGas.RegistrarTransaccion(abastecimiento);

            //MessageBox.Show(Convert.ToString(cantidadLitros));

            totoGas.EscribirArchivo(idBomba,fechaHora,cantidadLitros,precioDelDia,tipoDespacho,nombreCliente);

            double tiempoEnMinutos = cantidadLitros / litroPorMinuto;
            int duracionDeLlenado = (int)(tiempoEnMinutos * 60 * 1000);
            //MessageBox.Show(Convert.ToString(duracionDeLlenado));
            controladorBombas.SendCommand(Convert.ToString(idBomba),tipoDespacho,"ON", duracionDeLlenado); ;


            
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
            int idBomba = totoGas.Bombas[1].Id;

        }

        private void buttonDispensarBomba3_Click(object sender, EventArgs e)
        {
            int idBomba = totoGas.Bombas[2].Id;
        }

        private void buttonDispensarBomba4_Click(object sender, EventArgs e)
        {
            int idBomba = totoGas.Bombas[3].Id;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controladorBombas.Dispose();
            FormMenuPrincipal principal = new FormMenuPrincipal();
            principal.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoDespachoBomba1.SelectedIndex == 1)
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
    }
}
