using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuilaChiles.Business.Catalogos;
using QuilaChiles.Business.General;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.DTO;
using QuilaChiles.Entities.Transaccional;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Catalogos
{
    public partial class FrmInsumos : Form
    {
        private Insumo _insumo;
        private BusinessInsumos _nInsumos;
        private bool _modificaPresentacion = false;
        private List<DtoPresentaciones> _presentaciones;
        public FrmInsumos()
        {
            InitializeComponent();
        }

        private void CargaInicial()
        {
            try
            {
                _presentaciones = MetodosCatalogos.CargaPresentacionesConcatenadoComboCatalogos(null, null);
                MetodosCatalogos.CargaNegociosComboCatalogos(null, cmbNegociosRegistro);
                MetodosCatalogos.CargaUnidadesCombocatalogos(null, cmbUnidades);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LimpiaControles()
        {
            try
            {
                cmbNegociosRegistro.SelectedIndex = BusinessVariables.ComboBox.Index;
                cmbUnidades.SelectedIndex = BusinessVariables.ComboBox.Index;
                txtDescripcion.Text = @"0";
                txtStockMinimo.Text = @"0";
                txtStockMaximo.Text = @"0";
                LimpiaPresentaciones();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void LimpiaPresentaciones()
        {
            try
            {
                cmbPresentaciones.SelectedIndex = BusinessVariables.ComboBox.Index;
                txtRendimiento.Text = @"0";
                txtCosto.Text = @"0";
                _modificaPresentacion = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AgregarPresentacionInsumo()
        {
            try
            {
                if (cmbPresentaciones.SelectedIndex == BusinessVariables.ComboBox.Index)
                    throw new Exception("Debe seleccionar una presentacion");
                if (txtRendimiento.Text.Trim() == string.Empty || int.Parse(txtRendimiento.Text.Trim()) <= 0)
                    throw new Exception("Debe ingresar el rendimiento");
                if (txtCosto.Text.Trim() == string.Empty || int.Parse(txtCosto.Text.Trim()) <= 0)
                    throw new Exception("Debe ingresar el costo");
                foreach (DataGridViewRow row in dgPresentacionesInsumo.Rows.Cast<DataGridViewRow>().Where(row => (int)row.Cells[0].Value == int.Parse(cmbPresentaciones.SelectedValue.ToString())))
                {
                    if (_modificaPresentacion)
                    {
                        row.Cells[0].Value = cmbPresentaciones.SelectedValue;
                        row.Cells[1].Value = cmbPresentaciones.Text;
                        row.Cells[2].Value = txtRendimiento.Text.Trim();
                        row.Cells[3].Value = txtCosto.Text.Trim();
                        LimpiaPresentaciones();
                    }
                    else if (Mensajes.Confirmacion("Ya se ha agregado esta presentacion\n¿Desea qu se sume el rendimiento y costo?", Text) == DialogResult.Yes)
                    {
                        row.Cells[2].Value = int.Parse(row.Cells[2].Value.ToString()) + int.Parse(txtRendimiento.Text.Trim());
                        row.Cells[3].Value = int.Parse(row.Cells[3].Value.ToString()) + int.Parse(txtCosto.Text.Trim());
                        LimpiaPresentaciones();
                    }
                    return;
                }
                dgPresentacionesInsumo.Rows.Add(int.Parse(cmbPresentaciones.SelectedValue.ToString()), cmbPresentaciones.Text, txtRendimiento.Text, txtCosto.Text);
                LimpiaPresentaciones();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ModificarPresentacionInsumo()
        {
            try
            {
                if (dgPresentacionesInsumo.CurrentRow != null)
                {
                    cmbPresentaciones.SelectedValue = int.Parse(dgPresentacionesInsumo.CurrentRow.Cells[0].Value.ToString());
                    txtRendimiento.Text = dgPresentacionesInsumo.CurrentRow.Cells[2].Value.ToString();
                    txtCosto.Text = dgPresentacionesInsumo.CurrentRow.Cells[3].Value.ToString();
                    _modificaPresentacion = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void EliminarPresentacionInsumo()
        {
            try
            {
                if (dgPresentacionesInsumo.CurrentRow != null)
                    dgPresentacionesInsumo.Rows.RemoveAt(dgPresentacionesInsumo.CurrentRow.Index);
                LimpiaPresentaciones();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmInsumos_Load(object sender, EventArgs e)
        {
            try
            {
                _nInsumos = new BusinessInsumos();
                CargaInicial();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnAddPresentacion_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarPresentacionInsumo();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnDelPresentacion_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarPresentacionInsumo();
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
                if (cmbNegociosRegistro.SelectedIndex == BusinessVariables.ComboBox.Index)
                    throw new Exception("Debe seleccionar una Negocio");
                if (txtDescripcion.Text.Trim() == string.Empty)
                    throw new Exception("Debe ingresar una descripcion");
                if (cmbUnidades.SelectedIndex == BusinessVariables.ComboBox.Index)
                    throw new Exception("Debe seleccionar una unidad de medida");
                if (txtStockMinimo.Text.Trim() == string.Empty || int.Parse(txtStockMinimo.Text.Trim()) <= 0)
                    throw new Exception("Debe ingresar el stock minimo");
                if (txtStockMaximo.Text.Trim() == string.Empty || int.Parse(txtStockMaximo.Text.Trim()) <= 0)
                    throw new Exception("Debe ingresar el stock maximo");
                if (dgvInsumos.Rows.Count <= 0)
                    throw new Exception("Debe ingresar al menos una presentacion");


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
                if (ValidaCaptura())
                {
                    if (_insumo == null)
                        _insumo = new Insumo();
                    _insumo.IdNegocio = (int)cmbNegociosRegistro.SelectedValue;
                    _insumo.Descripcion = txtDescripcion.Text.Trim();
                    _insumo.IdUnidad = (int)cmbUnidades.SelectedValue;
                    _insumo.StockMinimo = Convert.ToDecimal(txtStockMinimo.Text);
                    _insumo.StockMaximo = Convert.ToDecimal(txtStockMaximo.Text);
                    _insumo.InsumoPresentacion = new List<InsumoPresentacion>();
                    foreach (DataGridViewRow presentacion in dgvInsumos.Rows)
                    {
                        _insumo.InsumoPresentacion.Add(new InsumoPresentacion { IdPresentacion = (int)presentacion.Cells[0].Value, RendimientoPromedio = (decimal)presentacion.Cells[2].Value });
                    }
                    _nInsumos.Guardar(_insumo);
                    LimpiaControles();
                    Mensajes.AlmacenExito(Text);
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEditPresentacion_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarPresentacionInsumo();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void cmbNegociosRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<DtoPresentaciones> tmpList = _presentaciones.Where(w => w.IdPresentacion == BusinessVariables.ComboBox.ValueMember).ToList();
                if (cmbNegociosRegistro.SelectedIndex != BusinessVariables.ComboBox.Index)
                {
                    tmpList.AddRange(_presentaciones.Where(w => w.IdNegocio == (int)cmbNegociosRegistro.SelectedIndex).ToList());
                    cmbPresentaciones.DataSource = tmpList;
                    cmbPresentaciones.DisplayMember = "Descripcion";
                    cmbPresentaciones.ValueMember = "IdPresentacion";
                }
                else
                {
                    cmbPresentaciones.DataSource = tmpList;
                    cmbPresentaciones.DisplayMember = "Descripcion";
                    cmbPresentaciones.ValueMember = "IdPresentacion";
                }
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
