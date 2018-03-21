using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Ventanilla.Logica.Clases
{
    public class clsConexion
    {
        public String setGetConexion()
        {

            return ConfigurationManager.ConnectionStrings["Cnsp"].ToString();
        }
    }
}
