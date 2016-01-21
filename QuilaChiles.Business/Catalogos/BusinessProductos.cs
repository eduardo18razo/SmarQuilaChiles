using System;
using System.Collections.Generic;
using System.Linq;
using QuilaChiles.Data;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Business.Catalogos
{
    public class BusinessProductos
    {
        private bool _proxy;

        public BusinessProductos(bool proxy = false)
        {
            _proxy = proxy;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> result = null;
            DbContext db = new DbContext();
            try
            {
                result = db.Producto.ToList();
                foreach (Producto producto in result)
                {
                    db.LoadProperty(producto, "Categoria");
                    if (producto.Categoria != null)
                        db.LoadProperty(producto.Categoria, "NegociosEmpresa");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
