using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PI_VentanillaUnica.Servicios
{
    /// <summary>
    /// Descripción breve de Ventanilla_Unica_Ws
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class Ventanilla_Unica_Ws : System.Web.Services.WebService
    {

        [WebMethod]
        public string wsNuevoRadicado(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado)
        {
            try
            {
                Ventanilla.Logica.Clases.clsProcedure conexionws = new Ventanilla.Logica.Clases.clsProcedure();
                return conexionws.stNuevoRadicado( CodigoRadicado,  CodigoTercero,  CodigoFuncionario,  CodigoUsuario,  FechaRadicado,  DescripcionRadicado);

            }
            catch (Exception ex) { throw ex; }       }


       
    }
}
