using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Interfaces
{
    public class clsRadicadoInterface
    {
        public long ln_CodigoRadicado { get; set; }
        public long? ln_CodTerceroRadicado { get; set; }
        public long? ln_CodAdmonRadicado { get; set; }
        public string st_FechaRadicado { get; set; }
        public string st_DescripcionRadicado { get; set; }
        public long? ln_CodUsuarioRadicado { get; set; }
    }
}
