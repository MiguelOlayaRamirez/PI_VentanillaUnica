using PI_VentanillaUnica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceDatos.Web.Interfaces.ConexionWS
{
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

  

        protected void txtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Ventanilla_Unica_Ws obVentanilla_Unica_Ws = new Ventanilla_Unica_Ws();
                string stMensaje = obVentanilla_Unica_Ws.stNuevoUsuario(Convert.ToInt64(txtCodigoUsuario.Text), txtNombreUsuario.Text, txtApellidosUsuario.Text, txtCargoUsuario.Text);

                Response.Write("<Script Language ='JavaScript'> parent.alert('" + stMensaje + "');</Script>");

            }
            catch (Exception ex)
            {
                Response.Write("<Script Language ='JavaScript'> parent.alert('" + ex.Message + "');</Script>");
            }
        }
    }
}