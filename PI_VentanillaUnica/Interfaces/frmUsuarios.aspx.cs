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
                if (string.IsNullOrEmpty(txtCodigoUsuario.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtApellidosUsuario.Text) || string.IsNullOrEmpty(txtCargoUsuario.Text)) throw new Exception("");
                Ventanilla.Logica.Clases.clsEncriptacion obclsEncriptacion = new Ventanilla.Logica.Clases.clsEncriptacion();
                lblPassword.Text = obclsEncriptacion.stEncriptar(txtCodigoUsuario.Text);

                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stInsertarClientes(lblPassword.Text, txtNombreUsuario.Text, txtApellidosUsuario.Text, txtCargoUsuario.Text);


            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + "¡¡¡ No pueden quedar campos vacíos" + ex.Message + " !!!" + "');</Script>"); }
        }

        protected void imaCancelUsuario_Click(object sender, ImageClickEventArgs e)
        {
            txtCodigoUsuario.Text = txtNombreUsuario.Text = txtApellidosUsuario.Text = txtCargoUsuario.Text = "";
        }
    }
}