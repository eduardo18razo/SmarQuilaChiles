using System.Collections.Generic;
using QuilaChiles.Entities.Catalogos;

namespace QuilaChiles.Entities.General
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public int IdColonia { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string CalleNo { get; set; }
        public string Email { get; set; }
        public byte[] Logo { get; set; }

        public virtual Colonias Colonias { get; set; }

        public virtual List<NegociosEmpresa> NegociosEmpresa { get; set; }
    }
}
