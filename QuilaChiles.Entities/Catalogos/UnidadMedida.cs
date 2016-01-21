using System.Collections.Generic;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.Catalogos
{
    public class UnidadMedida
    {
        public int IdUnidadMedida { get; set; }
        
        public string Descripcion { get; set; }

        public string Extracto { get; set; }

        public virtual List<Insumo> Insumo { get; set; }

        public virtual List<InsumoProducto> InsumoProducto { get; set; }

        public virtual List<Presentaciones> Presentaciones { get; set; }

        
    }
}
