using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Entities.Transaccional
{
    public class OrdenDetalle
    {
        public int IdDetalleOrden { get; set; }
        public int IdOrden { get; set; }
        public int IdProducto { get; set; }
        public int IdEStatus { get; set; }
        public string Observaciones { get; set; }


        public virtual Estatus Estatus { get; set; }

        public virtual Orden Orden { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
