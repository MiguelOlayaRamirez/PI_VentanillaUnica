using Pi_VentanillaUnicaJsonWs.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_PlanillaUnicaJson.Controladores
{

    public class clsClientesController { 

    public List<Modelo.clsClientes>  GetClientes()

    {
        try
        {

            WsClientes.WsClientes abwsClientes = new WsClientes.WsClientes();
               
            return Newtonsoft.Json.JsonConvert.DeserializeObject(abwsClientes.GetClientes()) as List<Modelo.clsClientes>;


        }
        catch (Exception ex) { throw ex; }
    }
}
}