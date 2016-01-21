using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuilaChiles.Data;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Business.General
{
    public class BusinessSucursal
    {
        private bool _proxy;
        public BusinessSucursal(bool proxy = false)
        {
            _proxy = proxy;
        }
        public void Guardar(SucursalNegocio sucursal)
        {
            DbContext db = new DbContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                if (sucursal.IdSucursal <= 0)
                    db.SucursalNegocio.AddObject(sucursal);
                else
                {
                    SucursalNegocio sn = db.SucursalNegocio.Single(s => s.IdSucursal == sucursal.IdSucursal);
                    sn.IdNegocio = sucursal.IdNegocio;
                    sn.IdColonia = sucursal.IdColonia;
                    sn.Nombre = sucursal.Nombre;
                    sn.CalleNo = sucursal.CalleNo;
                    sn.Activa = sucursal.Activa;
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
