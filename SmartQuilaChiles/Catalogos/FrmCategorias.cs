using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuilaChiles.Business.Catalogos;
using QuilaChiles.Business.General;
using QuilaChiles.Business.Utilidades;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.General;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Catalogos
{
    public partial class FrmCategorias : Form
    {
        private BusinessCategoria _nCategoria;

        private List<NegociosEmpresa> _lstNegocios;
        private Categoria _categoria;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void CargaNegocios()
        {
            try
            {
                _lstNegocios = MetodosCatalogos.CargaNegociosCategoriaComboCatalogos(cmbNegocios, cmbNegocioRegistro);
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
                _categoria = null;
                txtNombre.Clear();
                txtLogo.Clear();
                pbLogoCategoria.Image = null;
                if (!nuevo)
                    tbCategorias.SelectTab(0);
                else
                    txtNombre.Focus();
                CargaNegocios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                _nCategoria = new BusinessCategoria();
                CargaNegocios();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void CargaCategoriasNegocio(int idNegocio = 0, string filtroCategoria = "")
        {
            try
            {
                List<Categoria> source = new List<Categoria>();
                List<NegociosEmpresa> lstSelect = _lstNegocios;
                if (idNegocio != 0)
                    lstSelect = lstSelect.Where(w => w.IdNegocio == idNegocio).ToList();
                if (filtroCategoria != string.Empty)
                    source.AddRange(lstSelect.SelectMany(s => s.Categoria).Where(w => w.Descripcion.Contains(txtFiltro.Text)));
                else
                    source.AddRange(lstSelect.SelectMany(s => s.Categoria));
                lvCategorias.Items.Clear();
                ImageList imageList = new ImageList { ImageSize = new Size(64, 64) };

                foreach (Categoria categoria in source.OrderBy(o => o.Descripcion))
                {
                    imageList.Images.Add(Imagenes.ByteToImagen(categoria.Imagen));
                }
                lvCategorias.View = View.SmallIcon;
                lvCategorias.LargeImageList = imageList;
                lvCategorias.SmallImageList = imageList;
                int count = 0;
                foreach (Categoria categoria in source.OrderBy(o => o.Descripcion))
                {
                    lvCategorias.Items.Add(categoria.IdCategoria.ToString(), categoria.Descripcion, count);
                    count++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cmbNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNegocios.SelectedIndex == BusinessVariables.ComboBox.Index)
                {
                    lvCategorias.Items.Clear();
                    return;
                }
                CargaCategoriasNegocio((int)cmbNegocios.SelectedValue, txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void CargarCategoria(int idNegocio, int idCategoria)
        {
            try
            {
                _categoria = _lstNegocios.Where(n => n.IdNegocio == idNegocio).SelectMany(s => s.Categoria).SingleOrDefault(sd => sd.IdCategoria == idCategoria);
                if (_categoria == null) return;
                cmbNegocioRegistro.SelectedValue = _categoria.IdNegocio;
                txtNombre.Text = _categoria.Descripcion;
                pbLogoCategoria.Image = Imagenes.ByteToImagen(_categoria.Imagen);

                tbCategorias.SelectTab(1);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvCategorias.SelectedItems.Count <= 0)
                {
                    Mensajes.Informacion("Debe seleccionar una categoria a editar");
                    return;
                }
                foreach (ListViewItem item in lvCategorias.SelectedItems)
                {
                    CargarCategoria((int)cmbNegocios.SelectedValue, int.Parse(item.Name));
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
                ofdLogo.Filter = @"Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|PNG (*.png)|*.png";
                ofdLogo.FilterIndex = 3;
                ofdLogo.FileName = "Seleccione una imagen";
                ofdLogo.Title = @"Seleccione Imagen";
                ofdLogo.InitialDirectory = "c:\\";
                if (ofdLogo.ShowDialog() != DialogResult.OK)
                    return;
                pbLogoCategoria.Image = Image.FromFile(ofdLogo.FileName);
                txtLogo.Text = ofdLogo.FileName;
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private bool ValidaCaptura()
        {
            try
            {
                if (cmbNegocioRegistro.SelectedIndex == BusinessVariables.ComboBox.Index)
                {
                    Mensajes.Exclamacion("Debe seleccionar un negocio", Text);
                    return false;
                }
                if (txtNombre.Text.Trim() == string.Empty)
                {
                    txtNombre.Focus();
                    Mensajes.Exclamacion("Nombre es un campo requerido", Text);
                    return false;
                }

                if (pbLogoCategoria.Image == null)
                {
                    btnBuscar.Focus();
                    Mensajes.Exclamacion("Debe seleccionar un logo para esta categoria", Text);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCaptura()) return;
                if (_categoria == null)
                    _categoria = new Categoria();
                _categoria.IdNegocio = (int)cmbNegocioRegistro.SelectedValue;
                _categoria.Descripcion = txtNombre.Text.Trim();
                _categoria.Imagen = Imagenes.ImagenToByte(pbLogoCategoria.Image);
                _nCategoria.Guardar(_categoria);
                LimpiarDatos();
                Mensajes.AlmacenExito(Text);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                CargaCategoriasNegocio((int)cmbNegocios.SelectedValue, txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
