using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Net;

namespace PI_VentanillaUnica.Servicios
{
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]

    public class Ventanilla_Unica_Ws : System.Web.Services.WebService
    {
        public Ventanilla.Logica.Clases.clsSeguridad SoapHeader;
        public NetworkCredential Credentials;

        [WebMethod]
        [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
        public string wsNuevoRadicado(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado)
        {
            try
            {
                Ventanilla.Logica.Clases.clsProcedure conexionws = new Ventanilla.Logica.Clases.clsProcedure();
                return conexionws.stNuevoRadicado( CodigoRadicado,  CodigoTercero,  CodigoFuncionario,  CodigoUsuario,  FechaRadicado,  DescripcionRadicado);

            }
            catch (Exception ex) { throw ex; }
        }

        [WebMethod]

        public string wsNuevoDespacho(long CodigoRadicado, string Descripcion, string Destino, string FechaDespacho)
        {
            try
            {
                Ventanilla.Logica.Clases.clsProcedure conexionws = new Ventanilla.Logica.Clases.clsProcedure();
                return conexionws.stDespachoNuevo(CodigoRadicado, Descripcion, Destino, FechaDespacho);

            }
            catch (Exception ex) { throw ex; }
        }

        [WebMethod]
        public string stNuevoUsuario(string Identificacion, string setNombres, string setApellidos, string setCargo)
        {

            try
            {
                Ventanilla.Logica.Clases.clsProcedure conexionws = new Ventanilla.Logica.Clases.clsProcedure();
                return conexionws.stInsertarClientes(Identificacion, setNombres, setApellidos, setCargo);

            }
            catch (Exception ex) { throw ex; }
        }

        [WebMethod]
        public List<string> dsConsultaTerceros(string prefixText, int count)
        {
            Ventanilla.Logica.Clases.clsTerceroAutocompletar obclsTerceroAutocompletar = new Ventanilla.Logica.Clases.clsTerceroAutocompletar();
            DataSet dsConsulta = obclsTerceroAutocompletar.dsConsultarTercero(Convert.ToInt64(prefixText));

            List<string> Terceros = new List<string>();

            foreach (DataRow drRow in dsConsulta.Tables[0].Rows)
                Terceros.Add(drRow["Nombre"].ToString());

            return Terceros;
        }

        [WebMethod]
        public List<string> dsConsultaRadicado(string prefixText, int count)
        {
            Ventanilla.Logica.Clases.clsRadicadoAutocompletar obclsRadicadoAutocompletar = new Ventanilla.Logica.Clases.clsRadicadoAutocompletar();
            DataSet dsConsulta = obclsRadicadoAutocompletar.dsConsultarRadicado(Convert.ToInt64(prefixText));

            List<string> Radicados = new List<string>();

            foreach (DataRow drRow in dsConsulta.Tables[0].Rows)
                Radicados.Add(drRow["Descripcion"].ToString());

            return Radicados;
        }


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
        public DataSet dsConsulta(long lnId)
        {
            try
            {
                if (SoapHeader == null) throw new Exception("Requiere validación");

                if (!SoapHeader.blCredencialesValidas(SoapHeader))
                    throw new Exception("Requiere Validación");

                DataSet dsConsulta = new DataSet();

                return dsConsulta;



               
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
