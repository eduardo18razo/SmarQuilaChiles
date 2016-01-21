using System;
using System.Collections.Generic;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Entities.Transaccional
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Disponible { get; set; }
        
        public virtual List<InsumoProducto> InsumoProducto { get; set; }

        public virtual Categoria Categoria { get; set; }

        
        public virtual List<OrdenDetalle> OrdenDetalle { get; set; }
        

    }
}
