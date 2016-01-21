using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuilaChiles.Business.General;
using QuilaChiles.Business.Utilidades;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Configuracion
{
    public partial class FrmFirstTime : Form
    {
        private SettingsApplication _propiedades;
        public FrmFirstTime(SettingsApplication propiedades)
        {
            InitializeComponent();
            _propiedades = propiedades;
        }

        private void FrmFirstTime_Load(object sender, EventArgs e)
        {
            try
            {
                chkEsServer.Checked = _propiedades.Properties.EsServidor;
                chkTeclado.Checked = _propiedades.Properties.TecladoPantalla;
                chkBloquearMenus.Checked = _propiedades.Properties.BloqueaMenus;
                tvConfiguracion.ExpandAll();
                TreeNode node = tvConfiguracion.Nodes[0].Nodes.Cast<TreeNode>().SingleOrDefault(n => n.Name == "tvnGeneral");
                if (node != null)
                    tvConfiguracion.SelectedNode = node;
                }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _propiedades.Properties.PrimeraArranque = false;
                _propiedades.Guardar();
                Close();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnBuscarbd_Click(object sender, EventArgs e)
        {
            try
            {
                fd.Filter = @"Media Descriptor File|*.mdf";
                fd.FileName = txtPathDb.Text;
                if (fd.ShowDialog() != DialogResult.OK) return;
                if (fd.CheckFileExists)
                {
                    txtPathDb.Text = fd.FileName;
                    _propiedades.Properties.RutaBaseDatos = fd.FileName;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void chkEsServer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                btnBuscarbd.Enabled = !chkEsServer.Checked;
                _propiedades.Properties.EsServidor = chkEsServer.Checked;
                _propiedades.Properties.RutaBaseDatos = btnBuscarbd.Enabled ? txtPathDb.Text : string.Empty;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnImgSplash_Click(object sender, EventArgs e)
        {
            try
            {
                fd.Filter = @"Joint Photographic Experts Group JPG|*.jpg|Portable Network Graphic PNG|*.png|Bitmap image BMP|*.bmp|All image type|*.jpg;*png;*.bmp";
                fd.FileName = txtImageSplash.Text;
                if (fd.ShowDialog() != DialogResult.OK) return;
                if (fd.CheckFileExists)
                {
                    txtImageSplash.Text = fd.FileName;
                    _propiedades.Properties.SplasImage = Imagenes.ImagenToByte(Image.FromFile(fd.FileName));
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void chkTeclado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _propiedades.Properties.TecladoPantalla = chkTeclado.Checked;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void chkBloquearMenus_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _propiedades.Properties.BloqueaMenus = chkBloquearMenus.Checked;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void tvConfiguracion_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = e.Node;
                switch (node.Name)
                {
                    case "tvnGeneral":
                        lblApartado.Text = @"General";
                        pnlGeneral.Dock = DockStyle.Fill;
                        pnlContenedor.Controls.Add(pnlGeneral);
                        break;
                    case "tvnApariencia":
                        lblApartado.Text = @"Apariencia";
                        pnlContenedor.Controls.Remove(pnlGeneral);
                        break;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

    }
}
