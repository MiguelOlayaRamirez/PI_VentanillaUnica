using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class NuevoRadicado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Response.Redirect("Login.aspx");
                    // lblUsuario.Text = Session["Login"].ToString();
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
            lblMensaje.Text = obclsClientes.stNuevoRadicado(Convert.ToInt64(txtCodigoRadicado.Text), Convert.ToInt64(txtCodigoTercero.Text), Convert.ToInt64(txtCodigoFuncionario.Text), Convert.ToInt64(txtCodigoUsuario.Text), txtFechaRadicado.Text, txtDescripcionRadicado.Text);
            ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('"+lblMensaje.Text+"', '', 'success')</script>");
            txtCodigoRadicado.Text = "";
            txtCodigoRadicado.Text = "";
            txtCodigoFuncionario.Text = "";
            txtCodigoUsuario.Text = "";
            txtFechaRadicado.Text = "";
            txtDescripcionRadicado.Text = "";
            txtCodigoTercero.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Se Borraron los datos', '')</script>");

            txtCodigoRadicado.Text = "";
            txtCodigoRadicado.Text = "";
            txtCodigoFuncionario.Text = "";
            txtCodigoUsuario.Text = "";
            txtFechaRadicado.Text = "";
            txtDescripcionRadicado.Text = "";
            txtCodigoTercero.Text = "";
        }
    }
}