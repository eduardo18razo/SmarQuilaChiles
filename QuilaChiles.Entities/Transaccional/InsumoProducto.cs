using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Entities.Transaccional
{
    public class InsumoProducto
    {
        public int IdInsumoProducto { get; set; }
        public int IdNegocio { get; set; }
        public int IdInsumo { get; set; }
        public int IdProducto { get; set; }
        public int IdUnidad { get; set; }
        public decimal Cantidad { get; set; }
        public decimal CostoProduccion { get; set; }


        public virtual Insumo Insumo { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual NegociosEmpresa NegociosEmpresa { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }
    }
}
