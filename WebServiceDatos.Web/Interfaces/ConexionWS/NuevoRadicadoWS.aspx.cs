using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebServiceDatos.Web.Interfaces.ConexionWS
{
    public partial class NuevoRadicadoWS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                wsNuevoRadicado.Ventanilla_Unica_Ws obwsNuevoRadicado = new wsNuevoRadicado.Ventanilla_Unica_Ws();
                string stMensaje = obwsNuevoRadicado.wsNuevoRadicado(Convert.ToInt64(txtCodigoRadicado.Text), Convert.ToInt64(txtCodigoTercero.Text), Convert.ToInt64(txtCodigoFuncionario.Text), Convert.ToInt64(txtCodigoUsuario.Text), txtFechaRadicado.Text, txtDescripcionRadicado.Text);

                Response.Write("<Script Language ='JavaScript'> parent.alert('" + stMensaje + "');</Script>");

            }catch(Exception ex)
            {
                Response.Write("<Script Language ='JavaScript'> parent.alert('" + ex.Message + "');</Script>");
            }
        }
    }
}