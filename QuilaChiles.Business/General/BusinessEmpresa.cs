using System;
using System.Linq;
using QuilaChiles.Data;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Business.General
{
    public class BusinessEmpresa
    {
        public Empresa ObtenerEmpresa()
        {
            Empresa result;
            DbContext db;
            try
            {
                db= new DbContext();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
            
            try
            {
                result = db.Empresa.SingleOrDefault();
                if (result != null)
                    db.LoadProperty(result, "Colonias");
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

        public void GuardarEmpresa(Empresa empresa)
        {
            DbContext db = new DbContext();
            try
            {
                if (empresa.IdEmpresa <= 0)
                    db.Empresa.AddObject(empresa);
                else
                {
                    Empresa update = db.Empresa.SingleOrDefault(s => s.IdEmpresa == empresa.IdEmpresa);
                    if (update != null)
                    {
                        update.Nombre = empresa.Nombre;
                        update.IdColonia = empresa.IdColonia;
                        update.RazonSocial = empresa.RazonSocial;
                        update.RFC = empresa.RFC;
                        update.CalleNo = empresa.CalleNo;
                        update.Email = empresa.Email;
                        update.Logo = empresa.Logo;
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
