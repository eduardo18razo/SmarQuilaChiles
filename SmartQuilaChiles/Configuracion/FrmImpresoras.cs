using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuilaChiles.Business.Utilidades;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Configuracion
{
    public partial class FrmImpresoras : Form
    {
        public FrmImpresoras()
        {
            InitializeComponent();
        }

        private void ListarImpresoras()
        {
            try
            {
                cmbCocina.DataSource = Impresoras.ListarImpresoras();
                cmbTicket.DataSource = Impresoras.ListarImpresoras();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CargarImpresoras()
        {
            try
            {
                List<Impresora> impresoras = Impresoras.ObtenerImpresoras();
                if (impresoras == null) return;
                Impresora impresoraCocina = impresoras.SingleOrDefault(w => w.Nombre == "Cocina");
                if (impresoraCocina != null)
                    for (int c = 0; c < cmbCocina.Items.Count; c++)
                    {
                        if (cmbCocina.Items[c].ToString() == impresoraCocina.Ubicacion)
                            cmbCocina.SelectedIndex = c;
                    }
                    
                Impresora impresoraTicket = impresoras.SingleOrDefault(w => w.Nombre == "Ticket");
                if (impresoraTicket == null) return;
                for (int c = 0; c < cmbTicket.Items.Count; c++)
                {
                    if (cmbTicket.Items[c].ToString() == impresoraTicket.Ubicacion)
                        cmbTicket.SelectedIndex = c;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void FrmNegocios_Load(object sender, EventArgs e)
        {
            try
            {
                ListarImpresoras();
                CargarImpresoras();
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
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
                List<Impresora> impresoras = new List<Impresora>();
                impresoras.Add(new Impresora { Nombre = "Cocina", Ubicacion = cmbCocina.Text });
                impresoras.Add(new Impresora { Nombre = "Ticket", Ubicacion = cmbTicket.Text });
                Impresoras.GuardarImpresoras(impresoras);
                Mensajes.AlmacenExito(Text);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
