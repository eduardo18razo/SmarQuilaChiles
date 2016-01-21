using System;
using System.Collections.Generic;
using System.Linq;
using QuilaChiles.Business.General;
using QuilaChiles.Data;
using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Business.Catalogos
{
    public class BusinessUnidadMedida
    {
        private bool _proxy;

        public BusinessUnidadMedida(bool proxy = false)
        {
            _proxy = proxy;
        }
        public List<UnidadMedida> ObtenerUnidades(bool insertaSeleccion = false)
        {
            List<UnidadMedida> result;
            DbContext db = new DbContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.UnidadMedida.OrderBy(o=>o.Descripcion).ToList();
                if (insertaSeleccion)
                    result.Insert(0, new UnidadMedida { IdUnidadMedida = BusinessVariables.ComboBox.ValueMember, Descripcion = BusinessVariables.ComboBox.DisplayMember });
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

        public UnidadMedida ObtenerUnidad(int idUnidad)
        {
            UnidadMedida result;
            DbContext db = new DbContext();
            try
            {
                result = db.UnidadMedida.SingleOrDefault(s => s.IdUnidadMedida == idUnidad);
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

        public void Guardar(UnidadMedida unidad)
        {
            DbContext db = new DbContext();
            try
            {
                if (unidad.IdUnidadMedida <= 0)
                    db.UnidadMedida.AddObject(unidad);
                else
                {
                    UnidadMedida uMedida = db.UnidadMedida.SingleOrDefault(s => s.IdUnidadMedida == unidad.IdUnidadMedida);
                    if (uMedida != null)
                    {
                        uMedida.Descripcion = unidad.Descripcion;
                        uMedida.Extracto = unidad.Extracto;
                    }
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                db.Dispose();
            }
        }


    }
}
