using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using QuilaChiles.Business.General;

namespace QuilaChiles.Business.Utilidades
{
    public static  class Impresoras
    {
        private static string _folderSettings = Application.StartupPath + ConfigurationManager.AppSettings["SettingsFolder"];
        public static List<string> ListarImpresoras()
        {
            List<string> result = new List<string>();
            try
            {
                result.AddRange(from object printer in PrinterSettings.InstalledPrinters select printer.ToString());
                result.Insert(0, BusinessVariables.ComboBox.DisplayMember);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public static void GuardarImpresoras(List<Impresora> impresoras)
        {
            try
            {
                if (!Directory.Exists(_folderSettings))
                    Directory.CreateDirectory(_folderSettings);

                string file = _folderSettings + ConfigurationManager.AppSettings["FilePrinter"] + ".xml";
                using (var sw = new StreamWriter(file))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Impresora>));
                    serializer.Serialize(sw, impresoras);
                    sw.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static List<Impresora> ObtenerImpresoras()
        {
            List<Impresora> result = null;
            string file = _folderSettings + ConfigurationManager.AppSettings["FilePrinter"] + ".xml";
            try
            {
                if (File.Exists(file))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(List<Impresora>));
                    TextReader textReader = new StreamReader(file);
                    result = (List<Impresora>)deserializer.Deserialize(textReader);
                    textReader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }

    public class Impresora
    {
        public string Ubicacion { get; set; }
        public string Nombre { get; set; }
    }
}
