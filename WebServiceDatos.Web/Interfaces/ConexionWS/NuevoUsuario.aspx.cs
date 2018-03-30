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

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        NuevoUsuariows.NuevoUsuario obobNuevoUsuariows = new NuevoUsuariows.NuevoUsuario();
        //        string stMensaje = obobNuevoUsuariows.stNuevoUsuario(Convert.ToInt64(txtCodigoTercero.Text),  txtEmail.Text,  TxtNombre.Text, TxtTelefono.Text);

        //        Response.Write("<Script Language ='JavaScript'> parent.alert('" + stMensaje + "');</Script>");

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write("<Script Language ='JavaScript'> parent.alert('" + ex.Message + "');</Script>");
        //    }
        //}

        protected void txtGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoUsuariows.NuevoUsuario obobNuevoUsuariows = new NuevoUsuariows.NuevoUsuario();
                string stMensaje = obobNuevoUsuariows.stNuevoUsuario(Convert.ToInt64(txtCodigoUsuario.Text), txtNombreUsuario.Text, txtApellidosUsuario.Text, txtCargoUsuario.Text);

                Response.Write("<Script Language ='JavaScript'> parent.alert('" + stMensaje + "');</Script>");

            }
            catch (Exception ex)
            {
                Response.Write("<Script Language ='JavaScript'> parent.alert('" + ex.Message + "');</Script>");
            }
        }
    }
}