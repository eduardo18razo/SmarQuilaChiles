using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using QuilaChiles.Entities;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Business.General
{
    public class SettingsApplication
    {
        public SettingsApplicationProperties Properties = new SettingsApplicationProperties();

        public Empleado DatosUsuario;

        public SettingsApplication()
        {
            //CargaEstados();
            LoadSettings();
        }

        public void GenerarProperties()
        {
            try
            {
                Properties.EsServidor = false;
                Properties.PrimeraArranque = true;
                Properties.TecladoPantalla = false;
                Properties.SplasImage = null;

                using (var sw = new StreamWriter(Application.StartupPath + ConfigurationManager.AppSettings["SettingsFolder"] + ConfigurationManager.AppSettings["SettingsName"]))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SettingsApplicationProperties));
                    serializer.Serialize(sw, Properties);
                    sw.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Guardar()
        {
            try
            {
                GuardarCadenaConexion(Properties.RutaBaseDatos);
                using (var sw = new StreamWriter(Application.StartupPath + ConfigurationManager.AppSettings["SettingsFolder"] + ConfigurationManager.AppSettings["SettingsName"]))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SettingsApplicationProperties));
                    serializer.Serialize(sw, Properties);
                    sw.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GuardarCadenaConexion(string fileDb)
        {
            try
            {
                string exePath = Path.Combine(Application.StartupPath, "SmartQuilaChiles.exe");
                Configuration config = ConfigurationManager.OpenExeConfiguration(exePath);
                var setting = config.ConnectionStrings.ConnectionStrings["QuilaChilesConn"];
                if (setting != null)
                {
                    setting.ConnectionString =
                        string.Format(
                            "metadata=res://*/DbContext.csdl|res://*/DbContext.ssdl|res://*/DbContext.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\\v11.0;attachdbfilename={0};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;",
                            Properties.RutaBaseDatos);
                }

                config.Save();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        public void LoadSettings()
        {
            try
            {
                if (
                    !File.Exists(Application.StartupPath + ConfigurationManager.AppSettings["SettingsFolder"] +
                                 ConfigurationManager.AppSettings["SettingsName"]))
                    GenerarProperties();
                else
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof (SettingsApplicationProperties));
                    TextReader textReader =
                        new StreamReader(Application.StartupPath + ConfigurationManager.AppSettings["SettingsFolder"] +
                                         ConfigurationManager.AppSettings["SettingsName"]);
                    Properties = (SettingsApplicationProperties) deserializer.Deserialize(textReader);
                    textReader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //private void ApplySettingsGrid(DataGridView dg)
        //{
        //    //dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(Properties.BackgroundGridColumn);
        //    //dg.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(Properties.BackgroundGridRowHeader);
        //    //dg.DefaultCellStyle.SelectionBackColor = Color.FromArgb(Properties.BackgroundGridSelection);
        //    //dg.BackgroundColor = Color.FromArgb(Properties.BackgroundGrid);
        //    //dg.EnableHeadersVisualStyles = false;
        //}

        public void ApplySettings(Form frm, Form frmMain = null)
        {
            //frm.BackColor = Color.FromArgb(Properties.BackGround);
            //frm.Font = new Font(Properties.FontName, Properties.FontSize);
            //frm.ForeColor = Color.FromArgb(Properties.FontColor);
            //foreach (Control control in frm.Controls)
            //{
            //    control.BackColor = Color.FromArgb(Properties.BackGround);
            //    control.Font = new Font(Properties.FontName, Properties.FontSize);
            //    control.ForeColor = Color.FromArgb(Properties.FontColor);
            //    if (control.GetType().Name == "GroupBox")
            //    {
            //        foreach (Control ctl in control.Controls)
            //        {
            //            if (ctl.GetType().Name == "DataGridView")
            //            {
            //                ApplySettingsGrid((DataGridView) ctl);
            //            }
            //        }

            //    }
            //    if (control.GetType().Name == "DataGridView")
            //    {
            //        ApplySettingsGrid((DataGridView) control);
            //    }
            //    if (control.GetType().Name == "picture")
            //    {
                    
            //    }
            //}
        }

        public bool TienePermisoMenu()//Enumeradores.Menus idMenu
        {
            //bool result;
            //try
            //{
            //    result = DatosUsuario.UsuarioRol.Rol.RolesPantalla.Any(a => a.IdPantalla == (int)idMenu);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            return true;
        }

        public bool TienePermisosPantalla()//Enumeradores.PantallasEnum idPantalla
        {
            //bool result;
            //try
            //{
            //    result = DatosUsuario.UsuarioRol.Rol.RolesPantalla.Any(a => a.IdPantalla == (int) idPantalla);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
            return true;
        }


    }
}
