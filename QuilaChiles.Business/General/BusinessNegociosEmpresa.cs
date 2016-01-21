using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuilaChiles.Data;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Business.General
{
    public class BusinessNegociosEmpresa
    {
        private bool _proxy;
        public BusinessNegociosEmpresa(bool proxy = false)
        {
            _proxy = proxy;
        }
        public List<NegociosEmpresa> ObtenerNegocios(int idEmpresa)
        {
            DbContext db = new DbContext();
            List<NegociosEmpresa> result;
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.NegociosEmpresa.Where(w => w.IdEmpresa == idEmpresa).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }


        public List<NegociosEmpresa> ObtenerNegociosSucursales(int idEmpresa, bool insertaSeleccion = false)
        {
            DbContext db = new DbContext();
            List<NegociosEmpresa> result;
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.NegociosEmpresa.Where(w => w.IdEmpresa == idEmpresa).ToList();
                foreach (NegociosEmpresa negocio in result)
                {
                    db.LoadProperty(negocio, "SucursalNegocio");
                    foreach (SucursalNegocio sucursal in negocio.SucursalNegocio)
                    {
                        db.LoadProperty(sucursal, "Colonias");
                    }
                }
                if(insertaSeleccion)
                    result.Insert(0 , new NegociosEmpresa{IdNegocio = BusinessVariables.ComboBox.ValueMember, Nombre = BusinessVariables.ComboBox.DisplayMember});
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }

        public List<NegociosEmpresa> ObtenerNegociosCategoria(int idEmpresa, bool insertaSeleccion = false)
        {
            DbContext db = new DbContext();
            List<NegociosEmpresa> result;
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.NegociosEmpresa.Where(w => w.IdEmpresa == idEmpresa).ToList();
                foreach (NegociosEmpresa negocio in result)
                {
                    db.LoadProperty(negocio, "Categoria");
                }
                if (insertaSeleccion)
                    result.Insert(0, new NegociosEmpresa { IdNegocio = BusinessVariables.ComboBox.ValueMember, Nombre = BusinessVariables.ComboBox.DisplayMember });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }

        public NegociosEmpresa ObtenerNegocio(int idNegocio)
        {
            DbContext db = new DbContext();
            NegociosEmpresa result;
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.NegociosEmpresa.SingleOrDefault(s => s.IdNegocio == idNegocio);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
            finally
            {
                db.Dispose();
            }
            return result;
        }

        public void Guardar(NegociosEmpresa negocio)
        {
            DbContext db = new DbContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (negocio.IdNegocio <= 0)
                    db.NegociosEmpresa.AddObject(negocio);
                else
                {
                    NegociosEmpresa ne = db.NegociosEmpresa.SingleOrDefault(s => s.IdNegocio == negocio.IdNegocio);
                    if (ne != null)
                    {
                        ne.Nombre = negocio.Nombre;
                        ne.Logo = negocio.Logo;
                        ne.Activo = negocio.Activo;
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
