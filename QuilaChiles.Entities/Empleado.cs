using System.Collections.Generic;
using System.Security.Policy;
using QuilaChiles.Entities.General;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool Activo { get; set; }

        public virtual List<EmpleadoCargo> EmpleadoCargo { get; set; }

        public virtual List<Orden> Orden { get; set; }

        public virtual SucursalNegocio SucursalNegocio { get; set; }
    }
}
