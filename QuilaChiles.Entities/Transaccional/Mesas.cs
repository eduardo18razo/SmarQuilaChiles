using System.Collections.Generic;

namespace QuilaChiles.Entities.Transaccional
{
    public class Mesas
    {
        public int IdMesa { get; set; }
        public int IdNivel { get; set; }
        public string Descripcion { get; set; }
        public bool Activa { get; set; }

        public NivelSucursal NivelSucursal { get; set; }

        public List<Orden> Orden { get; set; }
    }
}
