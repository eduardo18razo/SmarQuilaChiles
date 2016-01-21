using System;
using System.Drawing;
using System.Windows.Forms;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.ControlesUsuario
{
    public partial class Teclado : UserControl
    {
        public string VentanaLlamada;
        public Teclado()
        {
            InitializeComponent();
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                lbl.BackColor = Color.DarkGray;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, VentanaLlamada);
            }
        }
        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Label lbl = (Label)sender;
                lbl.BackColor = Color.DimGray;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, VentanaLlamada);
            }
        }
    }
}
