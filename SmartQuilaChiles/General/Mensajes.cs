using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuilaChiles.General
{
    public class Mensajes
    {
        public static void Error(string mensaje, string titulo = "TPV")
        {
            titulo = titulo == string.Empty ? Application.ProductName : titulo;
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Informacion(string mensaje, string titulo = "TPV")
        {
            titulo = titulo == string.Empty ? Application.ProductName : titulo;
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Exclamacion(string mensaje, string titulo = "TPV")
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult Confirmacion(string mensaje, string titulo = "TPV")
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static void AlmacenExito(string titulo)
        {
            MessageBox.Show("Se guardo registro correctamente", titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
