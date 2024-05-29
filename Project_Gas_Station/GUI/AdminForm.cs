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
        public AdminForm()
        {
            InitializeComponent();
            InicializarControlBomba();
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

        private async void buttonDispensarBomba1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            // Simulación de una tarea que lleva tiempo
            for (int i = 0; i <= 100; i++)
            {
                await Task.Delay(50); // Simula una tarea asíncrona
                progressBar1.Value = i;
            }
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
                textBox1.Enabled = false;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }

        private void comboBoxSeleccionarBomba_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxSeleccionarBomba.SelectedIndex)
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
    }
}
