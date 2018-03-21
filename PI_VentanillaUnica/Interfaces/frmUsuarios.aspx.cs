using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class frmUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imaOkUsuario_Click(object sender, ImageClickEventArgs e)
        {
            try 
            {
                //    Ventanilla.Logica.Clases.clsUsuarios obclsUsuarios = new Ventanilla.Logica.Clases.clsUsuarios();
                //    string stMensaje = "";
                //    string stMensajeConfirmacion = "";

                //    if (string.IsNullOrEmpty(txtCodigoUsuario.Text)) stMensaje += "Código Usuario, \\n";
                //    if (string.IsNullOrEmpty(txtNombreUsuario.Text)) stMensaje += "Nombres Usuario y\\n";
                //    if (string.IsNullOrEmpty(txtApellidosUsuario.Text)) stMensaje += "Apellidos Usuario";

                //    if (!stMensaje.Equals("")) throw new Exception(stMensaje);

                //    stMensajeConfirmacion = obclsUsuarios.stInsertarUsuario(Convert.ToInt64(txtCodigoUsuario.Text),
                //        txtNombreUsuario.Text,
                //        txtApellidosUsuario.Text,
                //        txtCargoUsuario.Text);

                //    Response.Write("<script Language='JavaScript'>parent.alert('" + stMensajeConfirmacion + "');</Script>");
                //}

                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stInsertarClientes(Convert.ToInt64(txtCodigoUsuario.Text), txtNombreUsuario.Text, txtApellidosUsuario.Text, txtCargoUsuario.Text);


            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + "¡¡¡ Debe ingresar al menos los siguientes datos : \\n" + ex.Message + " !!!" + "');</Script>"); }
        }

        protected void imaCancelUsuario_Click(object sender, ImageClickEventArgs e)
        {
            txtCodigoUsuario.Text = txtNombreUsuario.Text = txtApellidosUsuario.Text = txtCargoUsuario.Text = "";
        }
    }
}