using System;
using System.Drawing;
using System.Windows.Forms;
using QuilaChiles.Business.Catalogos;
using QuilaChiles.Business.General;
using QuilaChiles.Business.Utilidades;
using QuilaChiles.Entities.General;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles.Configuracion
{
    public partial class FrmEmpresa : Form
    {
        private BusinessEmpresa _bEmpresa;
        
        private Empresa _empresa;
        private string _cpAnterior = string.Empty;
        
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void CargaEmpresa()
        {
            try
            {
                _empresa = _bEmpresa.ObtenerEmpresa();
                if (_empresa == null)
                {
                    _empresa = new Empresa();
                    return;
                }
                txtNombre.Text = _empresa.Nombre;
                txtRazonSocial.Text = _empresa.RazonSocial;
                txtRfc.Text = _empresa.RFC;
                txtCp.Text = _empresa.Colonias.CP.ToString();
                MetodosCatalogos.LlenaColonias(cmbColonias, txtCp, ref _cpAnterior);
                cmbColonias.SelectedValue = _empresa.IdColonia;
                txtCalle.Text = _empresa.CalleNo;
                txtEmail.Text = _empresa.Email;
                pbLogoEmpresa.Image = Imagenes.ByteToImagen(_empresa.Logo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private bool ValidaDatos()
        {
            try
            {
                if (txtNombre.Text.Trim() == string.Empty)
                {
                    txtNombre.Focus();
                    Mensajes.Exclamacion("Nombre es un campo obligatorio", Text);
                    return false;
                }
                if (txtRazonSocial.Text.Trim() == string.Empty)
                {
                    txtRazonSocial.Focus();
                    Mensajes.Exclamacion("Razon Social es un campo obligatorio", Text);
                    return false;
                }
                if (txtRfc.Text.Trim() == string.Empty)
                {
                    txtRfc.Focus();
                    Mensajes.Exclamacion("RFC es un campo obligatorio", Text);
                    return false;
                }
                if (txtCp.Text.Trim() == string.Empty)
                {
                    txtCp.Focus();
                    Mensajes.Exclamacion("Codigo Postal es un campo obligatorio", Text);
                    return false;
                }
                if ((int)cmbColonias.SelectedValue == BusinessVariables.ComboBox.ValueMember)
                {
                    cmbColonias.Focus();
                    Mensajes.Exclamacion("Colonia es un campo obligatorio", Text);
                    return false;
                }
                if (txtCalle.Text.Trim() == string.Empty)
                {
                    txtCalle.Focus();
                    Mensajes.Exclamacion("Calle y número es un campo obligatorio", Text); 
                    return false;
                }
                if (txtEmail.Text.Trim() == string.Empty)
                {
                    txtEmail.Focus();
                    Mensajes.Exclamacion("Email es un campo obligatorio", Text); 
                    return false;
                }
                if (pbLogoEmpresa.Image == null)
                {
                    pbLogoEmpresa.Focus();
                    Mensajes.Exclamacion("Logo es un campo obligatorio", Text);
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return true;
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
                pbLogoEmpresa.Image = Image.FromFile(ofdLogo.FileName);
                txtLogo.Text = ofdLogo.FileName;
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
                if (!ValidaDatos()) return;
                _empresa.Nombre = txtNombre.Text;
                _empresa.RazonSocial = txtRazonSocial.Text;
                _empresa.RFC = txtRfc.Text;
                _empresa.IdColonia = (int)cmbColonias.SelectedValue;
                _empresa.CalleNo = txtCalle.Text;
                _empresa.Email = txtEmail.Text;
                _empresa.Logo = Imagenes.ImagenToByte(pbLogoEmpresa.Image);
                _bEmpresa.GuardarEmpresa(_empresa);
                Mensajes.Exclamacion("Se guardo registro correctamente", Text);
            }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            try
            {
                _bEmpresa = new BusinessEmpresa();
                CargaEmpresa();
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
                    MetodosCatalogos.LlenaColonias(cmbColonias, (TextBox)sender, ref _cpAnterior);
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
                MetodosCatalogos.LlenaColonias(cmbColonias, (TextBox)sender, ref _cpAnterior);
             }
            catch (Exception ex)
            {
                Mensajes.Error(ex.Message, Text);
            }
        }
    }
}
