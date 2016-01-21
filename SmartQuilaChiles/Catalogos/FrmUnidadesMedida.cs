using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuilaChiles.Business.Catalogos;
using QuilaChiles.Entities.Catalogos;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Catalogos
{
    public partial class FrmUnidadesMedida : Form
    {
        private BusinessUnidadMedida _nUnidad;
        private List<UnidadMedida> _lstUnidades;
        private UnidadMedida _unidad;
        public FrmUnidadesMedida()
        {
            InitializeComponent();
        }

        private void CargaInicial()
        {
            try
            {
                _lstUnidades = _nUnidad.ObtenerUnidades();
                FiltroUnidades();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FiltroUnidades()
        {
            try
            {
                dgvUnidades.DataSource = null;
                if (_lstUnidades == null) return;
                if (txtDescripcionFiltro.Text.Trim() != string.Empty)
                    dgvUnidades.DataSource = _lstUnidades.Where(w => w.Descripcion.Contains(txtDescripcionFiltro.Text.Trim())).ToList();
                else
                    dgvUnidades.DataSource = _lstUnidades;

                if (dgvUnidades.Columns.Count > 1)
                    dgvUnidades.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CargaUnidad(int idUnidad)
        {
            try
            {
                _unidad = _nUnidad.ObtenerUnidad(idUnidad);
                if (_unidad != null)
                {
                    txtUnidad.Text = _unidad.Descripcion;
                    txtExtracto.Text = _unidad.Extracto;
                }
                tabControl1.SelectTab(1);
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
                if (txtUnidad.Text.Trim() == string.Empty)
                {
                    txtUnidad.Focus();
                    sb.Append("- Unidad es un campo requerido\n");
                    result = false;
                }

                if (txtExtracto.Text.Trim() == string.Empty)
                {
                    txtUnidad.Focus();
                    sb.Append("- Extracto es un campo requerido");
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

        private void LimpiarControles()
        {
            try
            {
                _unidad = null;
                txtUnidad.Text = string.Empty;
                txtExtracto.Text = string.Empty;
                CargaInicial();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmUnidadesMedida_Load(object sender, EventArgs e)
        {
            try
            {
                _nUnidad = new BusinessUnidadMedida();
                CargaInicial();
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
                if (_unidad == null)
                    _unidad = new UnidadMedida();
                _unidad.Descripcion = txtUnidad.Text.Trim();
                _unidad.Extracto = txtExtracto.Text.Trim();
                _nUnidad.Guardar(_unidad);
                LimpiarControles();
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
                LimpiarControles();
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
                if (dgvUnidades.CurrentRow != null)
                    CargaUnidad((int)dgvUnidades.Rows[dgvUnidades.CurrentRow.Index].Cells[0].Value);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void txtDescripcionFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                FiltroUnidades();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
