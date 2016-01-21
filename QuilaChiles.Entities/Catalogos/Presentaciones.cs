using System.Collections.Generic;
using QuilaChiles.Entities.General;
using QuilaChiles.Entities.Transaccional;

namespace QuilaChiles.Entities.Catalogos
{
    public class Presentaciones
    {
        public int IdPresentacion { get; set; }
        public int IdNegocio { get; set; }
        public int IdUnidadMedida { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public virtual List<InsumoPresentacion> InsumoPresentacion { get; set; }
        public virtual NegociosEmpresa NegociosEmpresa { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }
    }
}
