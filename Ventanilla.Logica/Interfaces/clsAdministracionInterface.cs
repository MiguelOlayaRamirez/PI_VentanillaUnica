using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Interfaces
{
    public class clsAdministracionInterface
    {
        public long ln_CodigoAdmon { get; set; }
        public string st_NombreAdmon { get; set; }
        public string st_ApellidoAdmon { get; set; }
        public string st_CargoAdmon { get; set; }
        public string st_AreaAdmon { get; set; }
        public long? ln_CodDespachoAdmon { get; set; }
        public long? ln_CodProcesoAdmon { get; set; }
    }
}
