﻿namespace Project_Gas_Station.GUI
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageDispensar = new TabPage();
            progressBar1 = new ProgressBar();
            panelBomba4 = new Panel();
            comboBox4 = new ComboBox();
            label7 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            panelBomba3 = new Panel();
            comboBox3 = new ComboBox();
            label6 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            panelBomba2 = new Panel();
            comboBox2 = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            panelBomba1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            buttonDispensarBomba1 = new Button();
            textBoxCantidadBomba1 = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            comboBoxSeleccionarBomba = new ComboBox();
            textBox5 = new TextBox();
            label3 = new Label();
            textBoxPrecioDelDia = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabPageEstadisticas = new TabPage();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            comboBox5 = new ComboBox();
            buttonFiltrar = new Button();
            dateTimePicker1 = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabPageDispensar.SuspendLayout();
            panelBomba4.SuspendLayout();
            panelBomba3.SuspendLayout();
            panelBomba2.SuspendLayout();
            panelBomba1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPageEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageDispensar);
            tabControl1.Controls.Add(tabPageEstadisticas);
            tabControl1.Location = new Point(8, 7);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1064, 654);
            tabControl1.TabIndex = 0;
            // 
            // tabPageDispensar
            // 
            tabPageDispensar.Controls.Add(progressBar1);
            tabPageDispensar.Controls.Add(panelBomba4);
            tabPageDispensar.Controls.Add(panelBomba3);
            tabPageDispensar.Controls.Add(panelBomba2);
            tabPageDispensar.Controls.Add(panelBomba1);
            tabPageDispensar.Controls.Add(panel1);
            tabPageDispensar.Location = new Point(4, 24);
            tabPageDispensar.Margin = new Padding(2);
            tabPageDispensar.Name = "tabPageDispensar";
            tabPageDispensar.Padding = new Padding(2);
            tabPageDispensar.Size = new Size(1056, 626);
            tabPageDispensar.TabIndex = 0;
            tabPageDispensar.Text = "Disepensar";
            tabPageDispensar.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(4, 545);
            progressBar1.Margin = new Padding(2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1047, 77);
            progressBar1.TabIndex = 5;
            // 
            // panelBomba4
            // 
            panelBomba4.BorderStyle = BorderStyle.FixedSingle;
            panelBomba4.Controls.Add(comboBox4);
            panelBomba4.Controls.Add(label7);
            panelBomba4.Controls.Add(button4);
            panelBomba4.Controls.Add(textBox4);
            panelBomba4.Location = new Point(792, 108);
            panelBomba4.Margin = new Padding(2);
            panelBomba4.Name = "panelBomba4";
            panelBomba4.Size = new Size(260, 433);
            panelBomba4.TabIndex = 4;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Cantidad", "Tanque Lleno" });
            comboBox4.Location = new Point(32, 69);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(195, 23);
            comboBox4.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 25);
            label7.Name = "label7";
            label7.Size = new Size(217, 15);
            label7.TabIndex = 6;
            label7.Text = "Seleccione su tipo de Despacho:";
            // 
            // button4
            // 
            button4.Location = new Point(78, 222);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(97, 38);
            button4.TabIndex = 3;
            button4.Text = "Dispensar";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(32, 131);
            textBox4.Margin = new Padding(2);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 51);
            textBox4.TabIndex = 0;
            // 
            // panelBomba3
            // 
            panelBomba3.BorderStyle = BorderStyle.FixedSingle;
            panelBomba3.Controls.Add(comboBox3);
            panelBomba3.Controls.Add(label6);
            panelBomba3.Controls.Add(button3);
            panelBomba3.Controls.Add(textBox3);
            panelBomba3.Location = new Point(531, 108);
            panelBomba3.Margin = new Padding(2);
            panelBomba3.Name = "panelBomba3";
            panelBomba3.Size = new Size(257, 433);
            panelBomba3.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cantidad", "Tanque Lleno" });
            comboBox3.Location = new Point(32, 69);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(196, 23);
            comboBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 25);
            label6.Name = "label6";
            label6.Size = new Size(217, 15);
            label6.TabIndex = 6;
            label6.Text = "Seleccione su tipo de Despacho:";
            // 
            // button3
            // 
            button3.Location = new Point(83, 222);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 38);
            button3.TabIndex = 3;
            button3.Text = "Dispensar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 131);
            textBox3.Margin = new Padding(2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 51);
            textBox3.TabIndex = 0;
            // 
            // panelBomba2
            // 
            panelBomba2.BorderStyle = BorderStyle.FixedSingle;
            panelBomba2.Controls.Add(comboBox2);
            panelBomba2.Controls.Add(label5);
            panelBomba2.Controls.Add(button2);
            panelBomba2.Controls.Add(textBox2);
            panelBomba2.Location = new Point(268, 108);
            panelBomba2.Margin = new Padding(2);
            panelBomba2.Name = "panelBomba2";
            panelBomba2.Size = new Size(258, 433);
            panelBomba2.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Cantidad", "Tanque Lleno" });
            comboBox2.Location = new Point(32, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(194, 23);
            comboBox2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 25);
            label5.Name = "label5";
            label5.Size = new Size(217, 15);
            label5.TabIndex = 6;
            label5.Text = "Seleccione su tipo de Despacho:";
            // 
            // button2
            // 
            button2.Location = new Point(83, 222);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(101, 38);
            button2.TabIndex = 1;
            button2.Text = "Dispensar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 131);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 51);
            textBox2.TabIndex = 0;
            // 
            // panelBomba1
            // 
            panelBomba1.BorderStyle = BorderStyle.FixedSingle;
            panelBomba1.Controls.Add(comboBox1);
            panelBomba1.Controls.Add(label2);
            panelBomba1.Controls.Add(buttonDispensarBomba1);
            panelBomba1.Controls.Add(textBoxCantidadBomba1);
            panelBomba1.Location = new Point(4, 108);
            panelBomba1.Margin = new Padding(2);
            panelBomba1.Name = "panelBomba1";
            panelBomba1.Size = new Size(260, 433);
            panelBomba1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cantidad", "Tanque Lleno" });
            comboBox1.Location = new Point(38, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 25);
            label2.Name = "label2";
            label2.Size = new Size(217, 15);
            label2.TabIndex = 4;
            label2.Text = "Seleccione su tipo de Despacho:";
            // 
            // buttonDispensarBomba1
            // 
            buttonDispensarBomba1.Location = new Point(82, 222);
            buttonDispensarBomba1.Margin = new Padding(2);
            buttonDispensarBomba1.Name = "buttonDispensarBomba1";
            buttonDispensarBomba1.Size = new Size(95, 38);
            buttonDispensarBomba1.TabIndex = 1;
            buttonDispensarBomba1.Text = "Dispensar";
            buttonDispensarBomba1.UseVisualStyleBackColor = true;
            buttonDispensarBomba1.Click += buttonDispensarBomba1_Click;
            // 
            // textBoxCantidadBomba1
            // 
            textBoxCantidadBomba1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCantidadBomba1.Location = new Point(38, 131);
            textBoxCantidadBomba1.Margin = new Padding(2);
            textBoxCantidadBomba1.Multiline = true;
            textBoxCantidadBomba1.Name = "textBoxCantidadBomba1";
            textBoxCantidadBomba1.Size = new Size(182, 51);
            textBoxCantidadBomba1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxSeleccionarBomba);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxPrecioDelDia);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 4);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 100);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(747, 28);
            label4.Name = "label4";
            label4.Size = new Size(136, 15);
            label4.TabIndex = 6;
            label4.Text = "Seleccionar Bomba:";
            // 
            // comboBoxSeleccionarBomba
            // 
            comboBoxSeleccionarBomba.FormattingEnabled = true;
            comboBoxSeleccionarBomba.Items.AddRange(new object[] { "Bomba 1", "Bomba 2", "Bomba 3", "Bomba 4" });
            comboBoxSeleccionarBomba.Location = new Point(747, 46);
            comboBoxSeleccionarBomba.Name = "comboBoxSeleccionarBomba";
            comboBoxSeleccionarBomba.Size = new Size(191, 23);
            comboBoxSeleccionarBomba.TabIndex = 5;
            comboBoxSeleccionarBomba.SelectedIndexChanged += comboBoxSeleccionarBomba_SelectedIndexChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(408, 46);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(230, 21);
            textBox5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(408, 28);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre del Cliente:";
            // 
            // textBoxPrecioDelDia
            // 
            textBoxPrecioDelDia.Enabled = false;
            textBoxPrecioDelDia.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrecioDelDia.Location = new Point(231, 38);
            textBoxPrecioDelDia.Multiline = true;
            textBoxPrecioDelDia.Name = "textBoxPrecioDelDia";
            textBoxPrecioDelDia.Size = new Size(104, 47);
            textBoxPrecioDelDia.TabIndex = 2;
            textBoxPrecioDelDia.Text = "56.90";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoGAS_sf;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 10);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Precio Del Día";
            // 
            // tabPageEstadisticas
            // 
            tabPageEstadisticas.Controls.Add(dateTimePicker1);
            tabPageEstadisticas.Controls.Add(buttonFiltrar);
            tabPageEstadisticas.Controls.Add(comboBox5);
            tabPageEstadisticas.Controls.Add(label8);
            tabPageEstadisticas.Controls.Add(dataGridView1);
            tabPageEstadisticas.Location = new Point(4, 24);
            tabPageEstadisticas.Margin = new Padding(2);
            tabPageEstadisticas.Name = "tabPageEstadisticas";
            tabPageEstadisticas.Padding = new Padding(2);
            tabPageEstadisticas.Size = new Size(1056, 626);
            tabPageEstadisticas.TabIndex = 1;
            tabPageEstadisticas.Text = "Estadisticas";
            tabPageEstadisticas.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1046, 478);
            dataGridView1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 29);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 1;
            label8.Text = "Filtrar:";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Abastecimientos por Fecha", "Abastecimientos Prepago", "Abastecimientos Tanque Lleno", "Bombas por Uso" });
            comboBox5.Location = new Point(79, 26);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(200, 23);
            comboBox5.TabIndex = 2;
            comboBox5.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.Location = new Point(315, 26);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(75, 23);
            buttonFiltrar.TabIndex = 3;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(79, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 21);
            dateTimePicker1.TabIndex = 4;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 672);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "AdminForm";
            Text = "TOTOGAS";
            FormClosed += AdminForm_FormClosed;
            tabControl1.ResumeLayout(false);
            tabPageDispensar.ResumeLayout(false);
            panelBomba4.ResumeLayout(false);
            panelBomba4.PerformLayout();
            panelBomba3.ResumeLayout(false);
            panelBomba3.PerformLayout();
            panelBomba2.ResumeLayout(false);
            panelBomba2.PerformLayout();
            panelBomba1.ResumeLayout(false);
            panelBomba1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPageEstadisticas.ResumeLayout(false);
            tabPageEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageDispensar;
        private Panel panelBomba4;
        private Panel panelBomba3;
        private Panel panelBomba2;
        private TextBox textBox2;
        private Panel panelBomba1;
        private TextBox textBoxCantidadBomba1;
        private Panel panel1;
        private TabPage tabPageEstadisticas;
        private Button button4;
        private TextBox textBox4;
        private Button button3;
        private TextBox textBox3;
        private Button button2;
        private Button buttonDispensarBomba1;
        private ProgressBar progressBar1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxPrecioDelDia;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxSeleccionarBomba;
        private TextBox textBox5;
        private ComboBox comboBox4;
        private Label label7;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button buttonFiltrar;
        private ComboBox comboBox5;
        private Label label8;
    }
}