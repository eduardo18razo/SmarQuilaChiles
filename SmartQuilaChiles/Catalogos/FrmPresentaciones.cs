using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuilaChiles.Business.Catalogos;
using QuilaChiles.Business.General;
using QuilaChiles.Entities.Catalogos;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Catalogos
{
    public partial class FrmPresentaciones : Form
    {
        private BusinessPresentaciones _nPresentaciones;
        private List<Presentaciones> _lstPresentaciones;
        private Presentaciones _presentacion;
        public FrmPresentaciones()
        {
            InitializeComponent();
        }

        private void CargaInicial()
        {
            try
            {
                MetodosCatalogos.CargaNegociosComboCatalogos(cmbNegocioFiltro, cmbNegocioRegistro);
                MetodosCatalogos.CargaUnidadesCombocatalogos(null, cmbMedidaRegistro);
                CargaPresentaciones();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CargaPresentaciones()
        {
            try
            {
                _lstPresentaciones = _nPresentaciones.ObtenerPresentaciones();
                dgvPresentaciones.DataSource = _lstPresentaciones;
                dgvPresentaciones.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FiltrarPresentaciones()
        {
            try
            {
                if (_lstPresentaciones == null) return;
                dgvPresentaciones.DataSource = null;
                if (cmbNegocioFiltro.SelectedIndex != BusinessVariables.ComboBox.Index)
                    dgvPresentaciones.DataSource = _lstPresentaciones.Where(w => w.Descripcion.Contains(txtPresentacionFiltro.Text.Trim()) && w.IdNegocio == (int)cmbNegocioFiltro.SelectedValue).ToList();
                else
                    dgvPresentaciones.DataSource = _lstPresentaciones.Where(w => w.Descripcion.Contains(txtPresentacionFiltro.Text.Trim())).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LimpiarControles()
        {
            try
            {
                _presentacion = null;
                cmbNegocioRegistro.SelectedIndex = BusinessVariables.ComboBox.Index;
                txtPresentacionRegistro.Text = string.Empty;
                cmbMedidaRegistro.SelectedIndex = BusinessVariables.ComboBox.Index;
                txtCantidad.Text = string.Empty;
                txtCosto.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidaCaptura()
        {
            bool result = true;
            StringBuilder mensaje = new StringBuilder();
            try
            {
                if (cmbNegocioRegistro.SelectedIndex == BusinessVariables.ComboBox.Index)
                {
                    txtPresentacionRegistro.Focus();
                    mensaje.Append("- Negocio es un campo requerido\n");
                    result = false;
                }

                if (txtPresentacionRegistro.Text.Trim() == string.Empty)
                {
                    txtPresentacionRegistro.Focus();
                    mensaje.Append("- Presentación es un campo requerido\n");
                    result = false;
                }

                if (cmbMedidaRegistro.SelectedIndex == BusinessVariables.ComboBox.Index)
                {
                    txtPresentacionRegistro.Focus();
                    mensaje.Append("- Medida es un campo requerido\n");
                    result = false;
                }

                if (txtCantidad.Text.Trim() == string.Empty)
                {
                    txtCantidad.Focus();
                    mensaje.Append("- Cantidad es un campo requerido\n");
                    result = false;
                }

                if (txtCosto.Text.Trim() == string.Empty)
                {
                    txtCosto.Focus();
                    mensaje.Append("- Costo es un campo requerido\n");
                    result = false;
                }
                if (!result)
                    Mensajes.Exclamacion(mensaje.ToString(), Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        private void FrmPresentaciones_Load(object sender, EventArgs e)
        {
            try
            {
                _nPresentaciones = new BusinessPresentaciones();
                CargaInicial();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void cmbNegocioFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FiltrarPresentaciones();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void txtPresentacionFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                FiltrarPresentaciones();
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
                LimpiarControles();
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
                if (_presentacion == null)
                    _presentacion = new Presentaciones();
                _presentacion.IdNegocio = (int)cmbNegocioRegistro.SelectedValue;
                _presentacion.IdUnidadMedida = (int)cmbMedidaRegistro.SelectedValue;
                _presentacion.Descripcion = txtPresentacionRegistro.Text.Trim();
                _presentacion.Cantidad = Convert.ToDecimal(txtCantidad.Text.Trim());
                _presentacion.Costo = Convert.ToDecimal(txtCosto.Text.Trim());

                _nPresentaciones.Guardar(_presentacion);
                LimpiarControles();
                Mensajes.AlmacenExito(Text);
                CargaInicial();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                General.Events.SoloNumerosEnteroDecimal(sender, e, Text);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                General.Events.SoloNumerosEnteros(sender, e, Text);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
