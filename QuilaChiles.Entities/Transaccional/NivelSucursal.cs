using System.Collections.Generic;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Entities.Transaccional
{
    public class NivelSucursal
    {
        public int IdNivel { get; set; }
        public int IdSucursal { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Mesas> Mesas { get; set; }
        public virtual SucursalNegocio SucursalNegocio { get; set; }
    }
}
