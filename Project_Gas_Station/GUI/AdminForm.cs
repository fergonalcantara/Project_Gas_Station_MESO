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
        private JsonHandler jsonHandler;
        public const double litroPorMinuto = 2.00;
        private int duracion;
        private int elapsed;

        public AdminForm()
        {
            InitializeComponent();
            this.totoGas = new Gasolinera();
            totoGas.LeerArchivo();
            this.controladorBombas = new ControladorSerial();
            CargarDatos();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            timer1.Interval = 8;
            timer1.Tick += timer1_Tick;
        }

        private void DispensarCombustible(TextBox textBoxCantidad, ComboBox comboBoxTipoDespacho, int indiceBomba)
        {
            if (comboBoxTipoDespacho.SelectedItem == "Cantidad")
            {
                int idBomba = indiceBomba;
                string fechaHora = DateTime.Now.ToString("dd / MM / yyyy");
                double cantidadLitros = Math.Round(Convert.ToDouble(textBoxCantidad.Text) / Convert.ToDouble(textBoxPrecioDelDia.Text), 2);
                double precioDelDia = Convert.ToDouble(textBoxPrecioDelDia.Text);
                string tipoDespacho = Convert.ToString(comboBoxTipoDespacho.Text);
                string nombreCliente = textBoxNombreCliente.Text;

                Abastecimiento abastecimiento = new Abastecimiento(idBomba, fechaHora, cantidadLitros, precioDelDia, tipoDespacho, nombreCliente);
                totoGas.RegistrarTransaccion(abastecimiento);
                totoGas.EscribirArchivo(idBomba, fechaHora, cantidadLitros, precioDelDia, tipoDespacho, nombreCliente);

                double tiempoEnMinutos = cantidadLitros / litroPorMinuto;
                int duracionDeLlenado = (int)(tiempoEnMinutos * 60 * 1000);
                MessageBox.Show(Convert.ToString(duracionDeLlenado));
                controladorBombas.SendCommand(Convert.ToString(idBomba), tipoDespacho, "ON", duracionDeLlenado);

                textBoxCantidad.Text = string.Empty;
                comboBoxTipoDespacho.Text = string.Empty;
                textBoxNombreCliente.Text = string.Empty;

                TimerParaLlenado(duracionDeLlenado);
            }
            else
            {
                int idBomba = indiceBomba;
                string fechaHora = DateTime.Now.ToString("dd / MM / yyyy");
                double cantidadLitros = Math.Round(Convert.ToDouble(textBoxCantidad.Text) / Convert.ToDouble(textBoxPrecioDelDia.Text), 2);
                double precioDelDia = Convert.ToDouble(textBoxPrecioDelDia.Text);
                string tipoDespacho = Convert.ToString(comboBoxTipoDespacho.Text);
                string nombreCliente = textBoxNombreCliente.Text;

                controladorBombas.SendCommand(Convert.ToString(idBomba), tipoDespacho, "ON", 0);

                Abastecimiento abastecimiento = new Abastecimiento(idBomba, fechaHora, cantidadLitros, precioDelDia, tipoDespacho, nombreCliente);
                totoGas.RegistrarTransaccion(abastecimiento);
                totoGas.EscribirArchivo(idBomba, fechaHora, cantidadLitros, precioDelDia, tipoDespacho, nombreCliente);



                textBoxCantidad.Text = string.Empty;
                comboBoxTipoDespacho.Text = string.Empty;
                textBoxNombreCliente.Text = string.Empty;
            }

            CargarDatos();
        }

        private void buttonDispensarBomba1_Click(object sender, EventArgs e)
        {
            DispensarCombustible(textBoxCantidadBomba1, comboBoxTipoDespachoBomba1, 1);
        }

        private void buttonDispensarBomba2_Click(object sender, EventArgs e)
        {
            DispensarCombustible(textBoxCantidadBomba2, comboBoxTipoDespachoBomba2, 2);
        }

        private void buttonDispensarBomba3_Click(object sender, EventArgs e)
        {
            DispensarCombustible(textBoxCantidadBomba3, comboBoxTipoDespachoBomba3, 3);
        }

        private void buttonDispensarBomba4_Click(object sender, EventArgs e)
        {
            DispensarCombustible(textBoxCantidadBomba4, comboBoxTipoDespachoBomba4, 4);
        }

        public void TimerParaLlenado(int duracionDelLlenado)
        {
            if (int.TryParse(Convert.ToString(duracionDelLlenado), out duracion))
            {
                if (duracion > 0)
                {
                    progressBar1.Value = 0;
                    elapsed = 0;

                    timer1.Start();
                }
                else
                {
                    MessageBox.Show("La duración debe ser mayor que cero.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una duración válida en milisegundos.");
            }
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

        private void comboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltrar.SelectedIndex == 0)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        public void CargarDatos()
        {
            dataGridView1.Rows.Clear();

            foreach (Abastecimiento abastecimiento in totoGas.Abastecimientos)
            {
                dataGridView1.Rows.Add([abastecimiento.IdBomba, abastecimiento.Fecha, abastecimiento.Cantidad, abastecimiento.PrecioPorLitro, abastecimiento.TipoDespacho, abastecimiento.NombreCliente]);
            }
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            string fechaSeleccionada = dateTimePicker1.Value.ToString("dd / MM / yyyy");
            switch (comboBoxFiltrar.SelectedIndex)
            {
                case 0:
                    dataGridView1.Rows.Clear();
                    foreach (Abastecimiento abastecimiento in totoGas.Abastecimientos)
                    {
                        if (fechaSeleccionada.Equals(abastecimiento.Fecha))
                        {
                            dataGridView1.Rows.Add([abastecimiento.IdBomba, abastecimiento.Fecha, abastecimiento.Cantidad, abastecimiento.PrecioPorLitro, abastecimiento.TipoDespacho, abastecimiento.NombreCliente]);
                        }
                    }
                    break;
                case 1:
                    dataGridView1.Rows.Clear();
                    foreach (Abastecimiento abastecimiento in totoGas.Abastecimientos)
                    {
                        if (abastecimiento.TipoDespacho.Equals("Cantidad"))
                        {
                            dataGridView1.Rows.Add([abastecimiento.IdBomba, abastecimiento.Fecha, abastecimiento.Cantidad, abastecimiento.PrecioPorLitro, abastecimiento.TipoDespacho, abastecimiento.NombreCliente]);
                        }
                    }
                    break;
                case 2:
                    dataGridView1.Rows.Clear();
                    foreach (Abastecimiento abastecimiento in totoGas.Abastecimientos)
                    {
                        if (abastecimiento.TipoDespacho.Equals("Tanque Lleno"))
                        {
                            dataGridView1.Rows.Add([abastecimiento.IdBomba, abastecimiento.Fecha, abastecimiento.Cantidad, abastecimiento.PrecioPorLitro, abastecimiento.TipoDespacho, abastecimiento.NombreCliente]);
                        }
                    }
                    break;
                case 3:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsed += timer1.Interval;

            int progressValue = (int)((double)elapsed / duracion * progressBar1.Maximum);

            if (progressValue <= progressBar1.Maximum)
            {
                progressBar1.Value = progressValue;
            }
            else
            {
                timer1.Stop();
                progressBar1.Value = progressBar1.Maximum;
                MessageBox.Show("Proceso Completo");
            }
        }

        private void buttonActualizarPrecio_Click(object sender, EventArgs e)
        {
            string precioActualizado = textBox1.Text;
            textBoxPrecioDelDia.Text = precioActualizado;
        }
    }
}