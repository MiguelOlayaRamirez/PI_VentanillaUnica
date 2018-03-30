using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceDatos.Web.Interfaces.ConexionWS
{
    public partial class wsNuevoDespacho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoDespachoWs.NuevoDespacho_Ws obNuevoDespacho_Ws = new NuevoDespachoWs.NuevoDespacho_Ws();
                string stMensaje = obNuevoDespacho_Ws.wsNuevoDespacho(Convert.ToInt64( txtCodigoDespacho.Text), txtDescripcion.Text, txtDestino.Text, txtFechaDespacho.Text);

                Response.Write("<Script Language ='JavaScript'> parent.alert('" + stMensaje + "');</Script>");

            }
            catch (Exception ex)
            {
                Response.Write("<Script Language ='JavaScript'> parent.alert('" + ex.Message + "');</Script>");
            }
        }
    }
}