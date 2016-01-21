using System;
using System.Windows.Forms;
using QuilaChiles.Business.General;
using SmartQuilaChiles.ControlesUsuario;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles
{
    public partial class FrmLogin : Form
    {
        private Teclado _teclado;
        private SettingsApplication _settings;
        public FrmLogin(SettingsApplication settings)
        {
            SuspendLayout();
            Layout += FrmLogin_Layout;
            ResumeLayout(false);
            InitializeComponent();
            _settings = settings;
        }
        void FrmLogin_Layout(object sender, LayoutEventArgs e)
        {
            Activate();
            FrmSplashScreen.CloseForm();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _teclado = new Teclado {Dock = DockStyle.Bottom};
            Controls.Add(_teclado);
            _teclado.Visible = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //_teclado.Visible = _settings.Properties.TecladoPantalla;
            //PopupTeclado popup = new PopupTeclado(new Teclado());
            //popup.Size = teclado.Size;
            //popup.Show(new Point(Width-teclado.Width, Height- teclado.Height));
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //_teclado.Visible = false;
        }
    }
}
