using System.Collections.Generic;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.General
{
    public class NegociosEmpresa
    {
        public int IdNegocio { get; set; }
        public int IdEmpresa { get; set; }
        public string Nombre { get; set; }
        public byte[] Logo { get; set; }
        public bool Activo { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual List<Insumo> Insumo { get; set; }

        public virtual List<InsumoProducto> InsumoProducto { get; set; }

        public virtual List<Categoria> Categoria { get; set; }

        public virtual List<SucursalNegocio> SucursalNegocio { get; set; }

        public virtual List<Presentaciones> Presentaciones { get; set; }

        
    }
}
