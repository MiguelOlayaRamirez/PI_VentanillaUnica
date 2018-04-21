using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace Pi_VentanillaUnicaJsonWs.Servicios
{

    /// <summary>
    /// Descripción breve de WsClientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
     [System.Web.Script.Services.ScriptService]

    public class WsClientes : System.Web.Services.WebService
    {
        
        [WebMethod]
        
        public string GetClientes(long Codigo)
        {
            Ventanilla.Logica.Clases.clsProcedure conexionws = new Ventanilla.Logica.Clases.clsProcedure();
            
            DataSet dsConsulta = conexionws.stBuscarRadicado(Codigo=1);
    

            DataTable dtDatos = new DataTable();
           
            if(dsConsulta.Tables[0].Rows.Count > 0) {
                dsConsulta.AcceptChanges();

                return  Newtonsoft.Json.JsonConvert.SerializeObject(dsConsulta);
                
            }
            string final = Newtonsoft.Json.JsonConvert.SerializeObject(dsConsulta.ToString());
            return final;
        

        }
    }
}
