using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartQuilaChiles.General
{
    public static class Events
    {

        //public static Usuario BusquedaUsuarios(ApplicationSettings opciones)
        //{
        //    FrmBusquedaUsuarios frmBusqueda = new FrmBusquedaUsuarios();
        //    opciones.ApplySettings(frmBusqueda);
        //    if (frmBusqueda.ShowDialog() != DialogResult.OK) return null;
        //    Usuario result = frmBusqueda.UsuarioSeleccionado;
        //    frmBusqueda.Dispose();
        //    return result;
        //}

        //public static Productos BusquedaProducto(ApplicationSettings opciones, int idRack = 0)
        //{
        //    FrmBusquedaProducto frmBusqueda = new FrmBusquedaProducto(null, idRack);
        //    opciones.ApplySettings(frmBusqueda);
        //    if (frmBusqueda.ShowDialog() != DialogResult.OK) return null;
        //    Productos result = frmBusqueda.ProductoSeleccionado;
        //    frmBusqueda.Dispose();
        //    return result;
        //}

        public static void InhabilitaTeclasControl(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Shift || e.Control)
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool SoloNumerosEnteros(object sender, KeyPressEventArgs e, string titulo)
        {
            bool result;
            try
            {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Escape || e.KeyChar == 46)
                {
                    Mensajes.Exclamacion("Solo se permiten numeros enteros", titulo);
                    e.Handled = true;
                }
                result = e.KeyChar == (char)Keys.Enter;
            }
            catch (Exception ex)
            {
                e.Handled = true;
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static bool SoloNumerosEnteroDecimal(object sender, KeyPressEventArgs e, string titulo)
        {
            bool result;
            try
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return false;
                }

                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Escape || e.KeyChar == 46)
                {
                    Mensajes.Exclamacion("Solo se permiten numeros enteros", titulo);
                    e.Handled = true;
                }
                result = e.KeyChar == (char)Keys.Enter;
            }
            catch (Exception ex)
            {
                e.Handled = true;
                throw new Exception(ex.Message);
            }
            return result;
        }

        public static void AbreVentana(Form open, Form padre, bool lockParent, int width, int height)
        {
            try
            {
                if (padre == null)
                    open.Show();
                else
                {
                    if (!lockParent)
                    {
                        open.MdiParent = padre;
                        open.StartPosition = FormStartPosition.Manual;
                        open.Location = new Point((width - open.Width) / 2, (height - open.Height) / 2);
                        open.Show();
                    }
                    else
                        open.ShowDialog(padre);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
