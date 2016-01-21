using System;
using System.Collections.Generic;
using System.Linq;
using QuilaChiles.Business.General;
using QuilaChiles.Data;
using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Business.Catalogos
{
    public class BusinessCategoria
    {
        private bool _proxy;
        public BusinessCategoria(bool proxy = false)
        {
            _proxy = proxy;
        }

        public List<Categoria> ObtenerCategoriasNegocio(int idNegocio, bool insertaSeleccion = false)
        {
            DbContext db = new DbContext();
            List<Categoria> result;
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                result = db.Categoria.Where(w => w.IdNegocio == idNegocio).ToList();
                if (insertaSeleccion)
                    result.Insert(0, new Categoria { IdNegocio = BusinessVariables.ComboBox.ValueMember, Descripcion = BusinessVariables.ComboBox.DisplayMember });
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

        public void Guardar(Categoria categoria)
        {
            DbContext db = new DbContext();
            try
            {
                db.ContextOptions.ProxyCreationEnabled = _proxy;
                categoria.FechaActualizacion = DateTime.Now;
                if (categoria.IdCategoria <= 0)
                {
                    categoria.FechaCreacion = DateTime.Now;
                    db.Categoria.AddObject(categoria);
                }
                else
                {
                    Categoria cat = db.Categoria.SingleOrDefault(s => s.IdCategoria == categoria.IdCategoria);
                    if (cat != null)
                    {
                        cat.Descripcion = categoria.Descripcion;
                        cat.Imagen = categoria.Imagen;
                        cat.IdNegocio = categoria.IdNegocio;
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
