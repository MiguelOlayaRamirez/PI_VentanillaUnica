using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class Radicados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Bienvenido Modulo de Radicados!', ' ', 'success')</script>");
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
            if (string.IsNullOrEmpty(txtCodigoRadicado.Text))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Ingresa el numero del Radicado', '', 'success')</script>");
                
                txtCodigoRadicado.Text = "";
            }
    }
}
}
