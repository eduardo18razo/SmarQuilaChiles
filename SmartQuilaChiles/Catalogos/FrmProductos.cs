using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuilaChiles.Entities.DTO;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Catalogos
{
    public partial class FrmProductos : Form
    {
        private List<DtoProductos> _lstProductos;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void CargaInicial()
        {
            try
            {
                _lstProductos = MetodosCatalogos.CargaProductosGrid();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void LlenaGrid()
        {
            try
            {
                _lstProductos = MetodosCatalogos.CargaProductosGrid();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                CargaInicial();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
