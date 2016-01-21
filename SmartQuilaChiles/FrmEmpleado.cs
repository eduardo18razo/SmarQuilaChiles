using QuilaChiles.Business.Catalogos;
using QuilaChiles.Business.General;
using QuilaChiles.Entities.General;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles
{
    public partial class FrmEmpleado : Form
    {
        private BusinessNegociosEmpresa _nNegocios;
        private BusinessSucursal _nSucursal;
        private BusinessColonias _nColonias;
        private List<NegociosEmpresa> _lstNegocios;
        private SucursalNegocio _sucursal;

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        //TODO: Cambiar ID de Empresa
        private void CargaNegocios()
        {
            try
            {
                _lstNegocios = _nNegocios.ObtenerNegociosSucursales(1, true);
                cmbNegocios.DataSource = _lstNegocios;
                cmbNegocios.DisplayMember = "Nombre";
                cmbNegocios.ValueMember = "IdNegocio";
                cmbNegocioRegistro.DataSource = _lstNegocios;
                cmbNegocioRegistro.DisplayMember = "Nombre";
                cmbNegocioRegistro.ValueMember = "IdNegocio";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                _nNegocios = new BusinessNegociosEmpresa();
                _nSucursal = new BusinessSucursal();
                _nColonias = new BusinessColonias();
                CargaNegocios();
                _sucursal = new SucursalNegocio();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
