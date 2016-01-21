using System.Collections.Generic;
using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Entities.Transaccional
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public int IdMesa { get; set; }
        public int IdEmpleadoAtiende { get; set; }
        public int IdEstatus { get; set; }

        public virtual Empleado Empleado { get; set; }
        public virtual Estatus Estatus { get; set; }
        public virtual Mesas Mesas { get; set; }
        public virtual List<OrdenDetalle> OrdenDetalle { get; set; }
    }
}
