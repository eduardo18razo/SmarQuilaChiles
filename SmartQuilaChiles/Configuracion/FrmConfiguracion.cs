using System;
using System.Linq;
using System.Windows.Forms;
using QuilaChiles.Business.General;
using QuilaChiles.Business.Utilidades;
using SmartQuilaChiles.Catalogos;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Configuracion
{
    public partial class FrmConfiguracion : Form
    {
        private SettingsApplication _settings;
        private int _width;
        private int _height;
        public FrmConfiguracion(SettingsApplication settings)
        {
            _settings = settings;
            InitializeComponent();
            
        }

        private void datosEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmEmpresa(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void impresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmImpresoras(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void negociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmNegocios(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmSucursales(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmCategorias(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmInsumos(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (MdiClient client in Controls.OfType<MdiClient>())
                {
                    _width = client.Width;
                    _height = client.Height;
                    client.BackgroundImage = Imagenes.ByteToImagen(_settings.Properties.SplasImage);
                    break;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }


        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmFirstTime(_settings), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                General.Events.AbreVentana(new FrmPresentaciones(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
try
            {
                General.Events.AbreVentana(new FrmUnidadesMedida(), this, Properties.Settings.BloquearMenus, _width, _height);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message);
            }
        }
    }
}
