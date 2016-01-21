using System.Collections.Generic;
using QuilaChiles.Entities.General;

namespace QuilaChiles.Entities.Catalogos
{
    public class Colonias
    {
        public int IdColonia { get; set; }
        public int? IdMunicipio { get; set; }
        public string Descripcion { get; set; }
        public int CP { get; set; }

        public virtual Municipios Municipios { get; set; }

        public virtual List<Empresa> Empresa { get; set; }

        public virtual List<SucursalNegocio> SucursalNegocio { get; set; }

    }
}
