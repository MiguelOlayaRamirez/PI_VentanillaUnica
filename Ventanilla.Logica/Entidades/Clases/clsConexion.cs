using System;
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
