using System.Collections.Generic;
using QuilaChiles.Entities.General;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.Catalogos
{
    public class Insumo
    {
        public int IdInsumo { get; set; }
        public int IdNegocio { get; set; }
        public string Descripcion { get; set; }
        public int IdUnidad { get; set; }
        public decimal Stock { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal StockMaximo { get; set; }
        public decimal Rendimiento { get; set; }

        public virtual NegociosEmpresa NegociosEmpresa { get; set; }
        
        public virtual List<InsumoProducto> InsumoProducto { get; set; }

        public virtual UnidadMedida UnidadMedida { get; set; }

        public virtual List<InsumoPresentacion> InsumoPresentacion { get; set; }
        
    }
}
