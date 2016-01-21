using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Entities.Transaccional
{
    public class InsumoPresentacion
    {
        public int IdInsumoPresentacion { get; set; }
        public int IdInsumo { get; set; }
        public int IdPresentacion { get; set; }
        public decimal RendimientoPromedio { get; set; }

        public virtual Insumo Insumo { get; set; }

        public virtual Presentaciones Presentaciones { get; set; }
    }
}
