using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuilaChiles.Business.General;
using QuilaChiles.Data;
using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Business.Catalogos
{
    public class BusinessPresentaciones
    {
        private bool _proxy;

        public BusinessPresentaciones(bool proxy = false)
        {
            _proxy = proxy;
        }

        public List<Presentaciones> ObtenerPresentaciones(bool insertaSeleccion = false)
        {
            List<Presentaciones> result;
            DbContext db = new DbContext();
            try
            {
                result = db.Presentaciones.ToList();
                foreach (Presentaciones presentacion in result)
                {
                    db.LoadProperty(presentacion, "UnidadMedida");
                }
                if (insertaSeleccion)
                    result.Insert(0, new Presentaciones { IdPresentacion = BusinessVariables.ComboBox.ValueMember, Descripcion = BusinessVariables.ComboBox.DisplayMember});
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }

        public void Guardar(Presentaciones presentacion)
        {
            DbContext db = new DbContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (presentacion.IdPresentacion <= 0)
                    db.Presentaciones.AddObject(presentacion);
                else
                {
                    Presentaciones pe = db.Presentaciones.SingleOrDefault(s => s.IdPresentacion == presentacion.IdPresentacion);
                    if (pe != null)
                    {
                        pe.IdNegocio = presentacion.IdNegocio;
                        pe.IdUnidadMedida = presentacion.IdUnidadMedida;
                        pe.Descripcion = presentacion.Descripcion;
                        pe.Cantidad = presentacion.Cantidad;
                        pe.Costo = presentacion.Costo;
                    }
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
