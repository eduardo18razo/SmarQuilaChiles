using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuilaChiles.Business.Catalogos;
using QuilaChiles.Business.General;
using QuilaChiles.Business.Utilidades;
using QuilaChiles.Entities.General;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Configuracion
{
    public partial class FrmSucursales : Form
    {

        private BusinessSucursal _nSucursal;
        private List<NegociosEmpresa> _lstNegocios;
        private SucursalNegocio _sucursal;
        private string _cpAnterior;

        public FrmSucursales()
        {
            InitializeComponent();
        }

        private void CargaNegocios()
        {
            try
            {
                _lstNegocios = MetodosCatalogos.CargaNegociosComboCatalogos(cmbNegocios, cmbNegocioRegistro);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void CargaSucursalesNegocio(int idNegocio)
        {
            try
            {
                List<SucursalNegocio> source = new List<SucursalNegocio>();
                foreach (NegociosEmpresa negocio in _lstNegocios.Where(w => w.IdNegocio == idNegocio))
                {
                    source.AddRange(negocio.SucursalNegocio);
                }
                lvSucursales.Items.Clear();
                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(64, 64);

                foreach (SucursalNegocio sucursal in source.OrderBy(o => o.Nombre))
                {
                    imageList.Images.Add(Imagenes.ByteToImagen(sucursal.NegociosEmpresa.Logo));
                }
                lvSucursales.View = View.SmallIcon;
                lvSucursales.LargeImageList = imageList;
                lvSucursales.SmallImageList = imageList;
                int count = 0;
                foreach (SucursalNegocio sucursal in source.OrderBy(o => o.Nombre))
                {
                    lvSucursales.Items.Add(sucursal.IdSucursal.ToString(), sucursal.Nombre, count);
                    count++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CargarSucursal(int idNegocio, int idSucursal)
        {
            try
            {

                _sucursal = _lstNegocios.Single(s => s.IdNegocio == idNegocio).SucursalNegocio.SingleOrDefault(sucursal => sucursal.IdSucursal == idSucursal);
                if (_sucursal == null) return;
                cmbNegocioRegistro.SelectedValue = _sucursal.IdNegocio;
                txtCp.Text = _sucursal.Colonias.CP.ToString();
                MetodosCatalogos.LlenaColonias(cmbColonia, txtCp, ref _cpAnterior);
                cmbColonia.SelectedValue = _sucursal.IdColonia;
                txtNombre.Text = _sucursal.Nombre;
                txtCalle.Text = _sucursal.CalleNo;
                chkActivo.CheckState = _sucursal.Activa ? CheckState.Checked : CheckState.Unchecked;
                tbSucursales.SelectTab(1);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidaCaptura()
        {
            try
            {
                if (cmbNegocioRegistro.SelectedIndex == BusinessVariables.ComboBox.Index)
                {
                    cmbNegocioRegistro.Focus();
                    Mensajes.Exclamacion("Negocio es un campo requerido", Text);
                    return false;
                }

                if (txtCp.Text.Trim() == string.Empty)
                {
                    txtCp.Focus();
                    Mensajes.Exclamacion("Codigo Postal es un campo requerido", Text);
                    return false;
                }

                if (cmbColonia.SelectedIndex == BusinessVariables.ComboBox.Index)
                {
                    cmbNegocioRegistro.Focus();
                    Mensajes.Exclamacion("Colonia es un campo requerido", Text);
                    return false;
                }

                if (txtNombre.Text.Trim() == string.Empty)
                {
                    txtNombre.Focus();
                    Mensajes.Exclamacion("Nombre es un campo requerido", Text);
                    return false;
                }

                if (txtCalle.Text.Trim() == string.Empty)
                {
                    txtCalle.Focus();
                    Mensajes.Exclamacion("Calle y Número es un campo requerido", Text);
                    return false;
                }

                if (chkActivo.CheckState == CheckState.Indeterminate)
                {
                    chkActivo.Focus();
                    Mensajes.Exclamacion("Debe indicar si la sucursal se encuentra activo", Text);
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
        }

        private void LimpiarDatos(bool nuevo = false)
        {
            try
            {
                _sucursal = null;
                cmbNegocioRegistro.SelectedIndex = BusinessVariables.ComboBox.Index;
                txtCp.Clear();
                cmbColonia.SelectedIndex = BusinessVariables.ComboBox.Index;
                txtNombre.Clear();
                txtCalle.Clear();
                chkActivo.CheckState = CheckState.Indeterminate;
                if (!nuevo)
                    tbSucursales.SelectTab(0);
                else
                    cmbNegocioRegistro.Focus();
                CargaNegocios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmSucursales_Load(object sender, EventArgs e)
        {
            try
            {
                _nSucursal = new BusinessSucursal();
                CargaNegocios();
                _sucursal = new SucursalNegocio();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void cmbNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNegocios.SelectedIndex == BusinessVariables.ComboBox.Index)
                {
                    lvSucursales.Items.Clear();
                    return;
                }
                CargaSucursalesNegocio((int)cmbNegocios.SelectedValue);
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
                if (lvSucursales.SelectedItems.Count <= 0)
                {
                    Mensajes.Informacion("Debe seleccionar una sucursal a editar");
                    return;
                }
                foreach (ListViewItem item in lvSucursales.SelectedItems)
                {
                    CargarSucursal((int)cmbNegocios.SelectedValue, int.Parse(item.Name));
                    break;
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCaptura()) return;
                if (_sucursal == null)
                    _sucursal = new SucursalNegocio();
                _sucursal.IdNegocio = (int)cmbNegocioRegistro.SelectedValue;
                _sucursal.IdColonia = (int)cmbColonia.SelectedValue;
                _sucursal.Nombre = txtNombre.Text.Trim();
                _sucursal.CalleNo = txtCalle.Text.Trim();
                _sucursal.Activa = chkActivo.Checked;
                _nSucursal.Guardar(_sucursal);
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

        private void txtCp_Leave(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text.Trim() != string.Empty)
                    MetodosCatalogos.LlenaColonias(cmbColonia, (TextBox)sender, ref _cpAnterior);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                General.Events.SoloNumerosEnteros(sender, e, Text);
                if (e.KeyChar == (char)Keys.Enter)
                    MetodosCatalogos.LlenaColonias(cmbColonia, (TextBox)sender, ref _cpAnterior);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
