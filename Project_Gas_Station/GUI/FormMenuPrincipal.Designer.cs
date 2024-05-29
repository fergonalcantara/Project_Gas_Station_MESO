namespace Project_Gas_Station
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            panelContenedor = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            button2 = new Button();
            buttonIngresar = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxContrasenia = new TextBox();
            textBoxUsuario = new TextBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(pictureBox1);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1257, 800);
            panelContenedor.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 203);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 364);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonIngresar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxContrasenia);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(664, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(593, 800);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(273, 153);
            label4.Name = "label4";
            label4.Size = new Size(104, 31);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(523, 728);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(56, 56);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.IndianRed;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Location = new Point(209, 520);
            buttonIngresar.Margin = new Padding(3, 4, 3, 4);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(191, 47);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.Text = "INGRESAR";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 425);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 295);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 2;
            label1.Text = "USUARIO:";
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.BorderStyle = BorderStyle.FixedSingle;
            textBoxContrasenia.Location = new Point(273, 425);
            textBoxContrasenia.Margin = new Padding(3, 4, 3, 4);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.PasswordChar = '*';
            textBoxContrasenia.Size = new Size(200, 24);
            textBoxContrasenia.TabIndex = 1;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Location = new Point(273, 295);
            textBoxUsuario.Margin = new Padding(3, 4, 3, 4);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(200, 24);
            textBoxUsuario.TabIndex = 0;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 800);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(777, 667);
            Name = "FormMenuPrincipal";
            Text = "   ";
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonIngresar;
        private Label label2;
        private Label label1;
        private TextBox textBoxContrasenia;
        private TextBox textBoxUsuario;
        private Button button2;
        private Label label4;
    }
}
