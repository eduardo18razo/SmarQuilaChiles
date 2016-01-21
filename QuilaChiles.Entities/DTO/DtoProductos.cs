using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuilaChiles.Entities.DTO
{
    public class DtoProductos
    {
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int IdNegocio { get; set; }
        public string DescripcionNegocio { get; set; }
        public int IdCategoria { get; set; }
        public string DescripcionCategoria { get; set; }

        public decimal Precio { get; set; }
        public bool Disponible { get; set; }

    }
}
