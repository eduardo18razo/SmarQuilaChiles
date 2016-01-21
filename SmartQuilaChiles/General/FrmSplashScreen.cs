using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuilaChiles.General
{
    public sealed partial class FrmSplashScreen : Form
    {
        private const double MDblOpacityIncrement = .05;
        private static Thread _msOThread;
        private static FrmSplashScreen _frmSplash;
        private string _statusDescripcion;
        private static bool _closed;
        public FrmSplashScreen(Image background)
        {
            BackgroundImage = background;
            InitializeComponent();
            UpdateTimer.Start();
        }

        static public void CloseForm()
        {
            _closed = true;
            _msOThread = null;
        }

        static private void ShowForm(Image background)
        {
            _frmSplash = new FrmSplashScreen(background);
            Application.Run(_frmSplash);
        }
        private void UpdateTimer_Tick(object sender, System.EventArgs e)
        {
            if (_closed)
                Close();
            lblStatus.Text = _statusDescripcion;
            if (!(MDblOpacityIncrement > 0)) return;
            if (Opacity < 1)
                Opacity += MDblOpacityIncrement;

        }
        static public void ShowSplashScreen(Image background)
        {
            if (_frmSplash != null) return;
            _msOThread = new Thread(() => ShowForm(background)) { IsBackground = true };
            _msOThread.SetApartmentState(ApartmentState.STA);
            _msOThread.Start();
        }

        public static void SetStatus(string status)
        {
            SetStatus(status, true);
        }

        static public void SetStatus(string newStatus, bool setReference)
        {
            if (_frmSplash == null)
                return;

            _frmSplash._statusDescripcion = newStatus;
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
