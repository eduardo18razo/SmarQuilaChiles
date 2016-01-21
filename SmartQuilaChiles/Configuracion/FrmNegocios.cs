using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuilaChiles.Business.General;
using QuilaChiles.Business.Utilidades;
using QuilaChiles.Entities.General;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Configuracion
{
    public partial class FrmNegocios : Form
    {
        private BusinessNegociosEmpresa _bNegocios;
        private List<NegociosEmpresa> _negocios;
        private NegociosEmpresa _negocio;

        public FrmNegocios()
        {
            InitializeComponent();
        }

        private void LlenaListaNegocios()
        {
            try
            {
                _negocios = _bNegocios.ObtenerNegocios(1);
                CargarNegocios(_negocios);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //todo:CAMBIAR ID DE EMPRESA
        private void CargarNegocios(List<NegociosEmpresa> source)
        {
            try
            {
                lvNegocios.Items.Clear();
                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(64, 64);

                foreach (NegociosEmpresa negocio in source.OrderBy(o => o.Nombre))
                {
                    imageList.Images.Add(Imagenes.ByteToImagen(negocio.Logo));
                }
                lvNegocios.View = View.SmallIcon;
                lvNegocios.LargeImageList = imageList;
                lvNegocios.SmallImageList = imageList;
                int count = 0;
                foreach (NegociosEmpresa negocio in source.OrderBy(o => o.Nombre))
                {
                    lvNegocios.Items.Add(negocio.IdNegocio.ToString(), negocio.Nombre, count);
                    count++;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CargarNegocio(int idNegocio)
        {
            try
            {
                _negocio = _bNegocios.ObtenerNegocio(idNegocio);
                if (_negocio == null) return;
                txtNombre.Text = _negocio.Nombre;
                pbLogoNegocio.Image = Imagenes.ByteToImagen(_negocio.Logo);
                chkActivo.CheckState = _negocio.Activo ? CheckState.Checked : CheckState.Unchecked;
                tabControl1.SelectTab(1);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LimpiarDatos(bool nuevo = false)
        {
            try
            {
                _negocio = null;
                txtNombre.Clear();
                txtLogo.Clear();
                chkActivo.CheckState = CheckState.Indeterminate;
                pbLogoNegocio.Image = null;
                if (!nuevo)
                    tabControl1.SelectTab(0);
                else
                    txtNombre.Focus();
                LlenaListaNegocios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidaCaptura()
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();
            try
            {
                if (txtNombre.Text.Trim() == string.Empty)
                {
                    txtNombre.Focus();
                    sb.Append("Nombre es un campo requerido\n");
                    result = false;
                }
                if (chkActivo.CheckState == CheckState.Indeterminate)
                {
                    chkActivo.Focus();
                    sb.Append("Debe indicar si el negocio se encuentra activo\n");
                    result = false;
                }
                if (pbLogoNegocio.Image == null)
                {
                    btnBuscar.Focus();
                    sb.Append("Debe seleccionar un logo para este negocio");
                    result = false;
                }

                if (!result)
                    Mensajes.Exclamacion(sb.ToString(), Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        private void FrmNegocios_Load(object sender, EventArgs e)
        {
            try
            {
                _bNegocios = new BusinessNegociosEmpresa();
                LlenaListaNegocios();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvNegocios.SelectedItems.Count <= 0)
                {
                    Mensajes.Informacion("Debe seleccionar un negocio a editar");
                    return;
                }
                foreach (ListViewItem item in lvNegocios.SelectedItems)
                {
                    CargarNegocio(int.Parse(item.Name));
                    break;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ofdLogo.Filter = BusinessVariables.OpenDialog.FilterImages;
                ofdLogo.FileName = BusinessVariables.OpenDialog.FileNameImages;
                ofdLogo.Title = BusinessVariables.OpenDialog.TitleImages;
                ofdLogo.InitialDirectory = BusinessVariables.OpenDialog.InitialDirectory;
                if (ofdLogo.ShowDialog() != DialogResult.OK)
                    return;
                pbLogoNegocio.Image = Image.FromFile(ofdLogo.FileName);
                txtLogo.Text = ofdLogo.FileName;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        //TODO: Cambiar ID EMPRESA
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCaptura()) return;
                if (_negocio == null)
                    _negocio = new NegociosEmpresa();
                _negocio.IdEmpresa = 1;
                _negocio.Nombre = txtNombre.Text.Trim();
                _negocio.Logo = Imagenes.ImagenToByte(pbLogoNegocio.Image);
                _negocio.Activo = chkActivo.Checked;
                _bNegocios.Guardar(_negocio);
                LimpiarDatos();
                Mensajes.AlmacenExito(Text);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos(true);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void txtBusquedaNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                CargarNegocios(txtBusquedaNombre.Text.Trim() == string.Empty ? _negocios : _negocios.Where(w => w.Nombre.Contains(txtBusquedaNombre.Text.Trim())).ToList());
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
