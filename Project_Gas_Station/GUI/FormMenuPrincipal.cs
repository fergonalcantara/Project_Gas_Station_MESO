using Project_Gas_Station.Clases;
using Project_Gas_Station.GUI;

namespace Project_Gas_Station
{
    public partial class FormMenuPrincipal : Form
    {
        private Autenticador autenticador = new Autenticador();
        public FormMenuPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contrasenia = textBoxContrasenia.Text;
            Autenticador.TipoDeUsuario userType = autenticador.Autenticar(usuario, contrasenia);

            switch (userType)
            {
                case Autenticador.TipoDeUsuario.Admin:
                    AdminForm adminForm = new AdminForm(); 
                    adminForm.Show();
                    this.Hide(); 
                    break;
                case Autenticador.TipoDeUsuario.Trabajador:
                    TrabajadorForm workerForm = new TrabajadorForm(); 
                    workerForm.Show();
                    this.Hide(); 
                    break;
                default:
                    MessageBox.Show("Usuario o contraseña incorrecta","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsuario.Clear();
                    textBoxContrasenia.Clear();
                    break;
            }
        }
    }
}
