using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Entities.Transaccional
{
    public class EmpleadoCargo
    {
        public int IdEmpleado { get; set; }
        public int IdCargo { get; set; }

        public virtual Cargo Cargo { get; set; }
        public virtual Empleado Empleado { get; set; }

    }
}
