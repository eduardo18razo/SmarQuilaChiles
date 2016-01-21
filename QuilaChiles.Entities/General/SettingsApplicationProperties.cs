using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuilaChiles.Entities.General
{
    public class SettingsApplicationProperties
    {
        public bool PrimeraArranque { get; set; }

        public byte[] SplasImage { get; set; }

        public bool EsServidor { get; set; }

        public string RutaBaseDatos { get; set; }

        public bool TecladoPantalla { get; set; }

        public bool BloqueaMenus { get; set; }



    }
}
