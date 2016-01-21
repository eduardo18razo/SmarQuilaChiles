using System;
using System.Collections.Generic;
using System.ComponentModel;
using QuilaChiles.Entities.General;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.Catalogos
{
    public class Categoria
    {
        [DisplayName("Id Categoria")]
        public int IdCategoria { get; set; }

        public int IdNegocio { get; set; }

        [DisplayName("Nombre")]
        public string Descripcion { get; set; }

        [DisplayName("Fecha Creacion")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Fecha ult. Act.")]
        public DateTime FechaActualizacion { get; set; }

        [DisplayName("Logo")]
        public byte[] Imagen { get; set; }

        public virtual NegociosEmpresa NegociosEmpresa { get; set; }

        public List<Producto> Producto { get; set; }
    }
}
