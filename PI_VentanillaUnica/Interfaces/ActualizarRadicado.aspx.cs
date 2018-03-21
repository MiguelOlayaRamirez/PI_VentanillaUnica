using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class ActualizarRadicado : System.Web.UI.Page
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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stActualizarRadicado(Convert.ToInt64(txtCodigoRadicado.Text), Convert.ToInt64(txtCodigoTercero.Text), Convert.ToInt64(txtCodigoAdministrativo.Text), txtFechaRadicado.Text, txtDescripcion.Text, Convert.ToInt64(txtCodigoUsuario.Text));
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
                        txtCodigoRadicado.Text = "";
                        txtCodigoTercero.Text = "";
                        txtCodigoAdministrativo.Text = "";
                        txtFechaRadicado.Text = "";
                        txtDescripcion.Text = "";
                        txtCodigoUsuario.Text = "";


            }
            catch (Exception ex) { lblMensaje.Text = ex.Message; }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Boton fuera de funcionamiento', 'Gracias')</script>");

                //lblMensaje.Text = "";
                //Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                //DataSet dsConsulta = obclsClientes.stBuscarRadicado(Convert.ToInt64(txtCodigoRadicado.Text));




            }
            catch (Exception ex) { lblMensaje.Text = ex.Message; }
        }
    }
}