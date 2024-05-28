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
        public AdminForm()
        {
            InitializeComponent();
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
            FormMenuPrincipal principal = new FormMenuPrincipal();
            principal.Show();
        }
    }
}
