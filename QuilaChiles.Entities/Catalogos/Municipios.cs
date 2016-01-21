using System.Collections.Generic;

namespace QuilaChiles.Entities.Catalogos
{
    public class Municipios
    {
        public int IdMunicipio { get; set; }
        public int? IdEstado { get; set; }
        public string Descripcion { get; set; }

        public virtual Estados Estados { get; set; }
        public virtual List<Colonias> Colonias { get; set; }
    }
}
