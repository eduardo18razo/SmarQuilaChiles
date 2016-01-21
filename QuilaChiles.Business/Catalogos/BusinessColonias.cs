using System;
using System.Collections.Generic;
using System.Linq;
using QuilaChiles.Business.General;
using QuilaChiles.Data;
using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Business.Catalogos
{
    public class BusinessColonias
    {
        public List<Colonias> ObtenerTodo(bool insertaSeleccion = false)
        {
            DbContext db = new DbContext();
            List<Colonias> result;
            try
            {
                result = db.Colonias.ToList();
                if (insertaSeleccion)
                    result.Insert(0, new Colonias { Descripcion = BusinessVariables.ComboBox.DisplayMember, IdColonia = BusinessVariables.ComboBox.ValueMember });
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

        public List<Colonias> BuscarColoniaCp(int cp, bool insertaSeleccion = false)
        {
            DbContext db = new DbContext();
            List<Colonias> result;
            try
            {
                result = db.Colonias.Where(s => s.CP == cp).OrderBy(o => o.Descripcion).ToList();
                if (insertaSeleccion)
                    result.Insert(0, new Colonias { Descripcion = BusinessVariables.ComboBox.DisplayMember, IdColonia = BusinessVariables.ComboBox.ValueMember });
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
    }

}
