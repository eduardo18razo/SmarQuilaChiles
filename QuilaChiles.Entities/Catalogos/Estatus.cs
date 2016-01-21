using System.Collections.Generic;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.Catalogos
{
    public class Estatus
    {
        public int IdEstatus { get; set; }
        public int Descripcion { get; set; }
        public string TipoEstatus { get; set; }

        public virtual List<Orden> Orden { get; set; }

        public virtual List<OrdenDetalle> OrdenDetalle { get; set; }
    }
}
