using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using Newtonsoft.Json;
using PI_PlanillaUnicaJson.Controladores;
using PI_PlanillaUnicaJson.Modelo;

namespace PI_PlanillaUnicaJson.Vistas
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gvwDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet dsConsulta = new DataSet();
            clsClientesController controlador = new clsClientesController();
            gvwDatos.DataSource = controlador.GetClientes();
            gvwDatos.DataBind();
        }
    }
}


                