using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Interfaces
{
    public class clsDespachoInterface
    {
        public long ln_CodigoDespacho { get; set; }
        public string st_DescripcionDespacho { get; set; }
        public string st_DestinoDespacho { get; set; }
        public string st_FechaDespacho { get; set; }
    }
}
