using System;
using System.Collections.Generic;
using System.Linq;
using QuilaChiles.Data;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Business.Catalogos
{
    public class BusinessInsumos
    {
        private bool _proxy;

        public BusinessInsumos(bool proxy = false)
        {
            _proxy = proxy;
        }

        public object ObtenerInsumosGrid(int idNegocio)
        {
            object result = null;
            DbContext db = new DbContext();
            try
            {
                var y = db.Insumo
                    .Where(f => f.IdNegocio == idNegocio)
                    .Select(s => new {s.IdInsumo, s.Descripcion, Unidad = s.UnidadMedida.Descripcion})
                    .ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public void Guardar(Insumo insumo)
        {
            DbContext db = new DbContext();
            try
            {
                if (insumo.IdInsumo <= 0)
                    db.Insumo.AddObject(insumo);
                else
                {
                    Insumo uInsumo = db.Insumo.SingleOrDefault(s => s.IdInsumo == insumo.IdInsumo);
                    if (uInsumo != null)
                    {
                        uInsumo.IdNegocio = insumo.IdNegocio;
                        uInsumo.IdUnidad = insumo.IdUnidad;
                        uInsumo.Descripcion = insumo.Descripcion;
                        uInsumo.StockMinimo = insumo.StockMinimo;
                        uInsumo.StockMaximo = insumo.StockMaximo;
                        foreach (InsumoPresentacion presentacion in uInsumo.InsumoPresentacion)
                        {
                            db.InsumoPresentacion.DeleteObject(presentacion);
                        }
                        uInsumo.InsumoPresentacion = insumo.InsumoPresentacion;
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
