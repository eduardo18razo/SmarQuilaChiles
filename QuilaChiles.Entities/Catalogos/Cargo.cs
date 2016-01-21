using System.Collections.Generic;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.Catalogos
{
    public class Cargo
    {
        public int IdCargo { get; set; }
        public string Descripcion { get; set; }

        public virtual List<EmpleadoCargo> EmpleadoCargo { get; set; }
    }
}
