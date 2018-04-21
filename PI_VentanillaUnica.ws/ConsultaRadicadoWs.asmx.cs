using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace PI_VentanillaUnica.ws
{
    /// <summary>
    /// Descripción breve de ConsultaRadicadoWs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class ConsultaRadicadoWs : System.Web.Services.WebService
    {
        public Ventanilla.Logica.Clases.clsSeguridad SoapHeader;
        
        [WebMethod]
        [System.Web.Services.Protocols.SoapHeader("SoapHeader")]

        public string AutenticacionUsuario()
        {
            try
            {
                if (SoapHeader == null) return "-1";
                if (!SoapHeader.blCredencialesValidas(SoapHeader.stToken)) return "-1";

                string stToken = Guid.NewGuid().ToString();

                HttpRuntime.Cache.Add(stToken,
                SoapHeader.stToken,
                null,
                System.Web.Caching.Cache.NoAbsoluteExpiration,
                TimeSpan.FromMinutes(30),
                System.Web.Caching.CacheItemPriority.NotRemovable,
                null);

                return stToken;
            }
            catch (Exception ex) { throw ex; }
        }
        [WebMethod]
        [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
        public DataSet wsConsultaRadicado(long txtCodigoRadicado)
        {

            try
            {


                if (SoapHeader == null) throw new Exception("Requiere validación");

                if (!SoapHeader.blCredencialesValidas(SoapHeader))
                    throw new Exception("Requiere Validación");
                Ventanilla.Logica.Clases.clsProcedure conexionws = new Ventanilla.Logica.Clases.clsProcedure();
               // DataSet dsConsulta = new DataSet();
                DataSet dsConsulta = conexionws.stBuscarRadicado(txtCodigoRadicado);
               

                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    dsConsulta.AcceptChanges();

                    return dsConsulta;

                }
                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}




