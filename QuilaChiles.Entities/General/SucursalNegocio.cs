using System.Collections.Generic;
using QuilaChiles.Entities.Catalogos;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.General
{
    public class SucursalNegocio
    {
        public int IdSucursal { get; set; }
        public int IdNegocio { get; set; }
        public int IdColonia { get; set; }
        public string Nombre { get; set; }
        public string CalleNo { get; set; }
        public bool Activa { get; set; }

        public virtual NegociosEmpresa NegociosEmpresa { get; set; }
        public virtual List<NivelSucursal> NivelSucursal { get; set; }
        public virtual Colonias Colonias { get; set; }

        public virtual List<Empleado> Empleado { get; set; }
    }
}
