using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PI_VentanillaUnica
{
    /// <summary>
    /// Descripción breve de NuevoUsuario
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
     [System.Web.Script.Services.ScriptService]
    public class NuevoUsuario : System.Web.Services.WebService
    {

        [WebMethod]
        public string stNuevoUsuario(long Identificacion, string setNombres, string setApellidos, string setCargo)
        {
           
                try
                {
                    Ventanilla.Logica.Clases.clsProcedure conexionws = new Ventanilla.Logica.Clases.clsProcedure();
                    return conexionws.stInsertarClientes( Identificacion,  setNombres,  setApellidos,  setCargo);

                }
                catch (Exception ex) { throw ex; }
            }
        }
    }

