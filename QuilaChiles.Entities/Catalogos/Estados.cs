using System.Collections.Generic;

namespace QuilaChiles.Entities.Catalogos
{
    public class Estados
    {
        public int IdEstado { get; set; }
        public string Descripcion { get; set; }
        public virtual List<Municipios> Municipios { get; set; }
    }
}
