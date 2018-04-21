using System;
using System.Collections.Generic;
using System.Data;
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
                //string stEmail = string.Empty;

                if (Session["sessionEmail"] == null)
                {
                    Response.Redirect("../Interfaces/Login.aspx");
                    // lblUsuario.Text = Session["Login"].ToString();
                }
                /*else if (Request.QueryString["stEmail"] != null)
                        stEmail = Request.QueryString["stEmail"].ToString();*///Esto para atrapar datos enviados desde otro formulario, en este caso desde el Login
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoFuncionario.Text) || !string.IsNullOrEmpty(txtCodigoTercero.Text) || !string.IsNullOrEmpty(txtDescripcionRadicado.Text) || !string.IsNullOrEmpty(txtFechaRadicado.Text))
            {
                string stNombreUsuario = null;

                stNombreUsuario = Session["sessionEmail"].ToString();

                Controles.RecuperarPasswordController obRecuperarPasswordController = new Controles.RecuperarPasswordController();
                Ventanilla.Logica.Interfaces.clsUsuariosInterface obclsUsuariosInterface = new Ventanilla.Logica.Interfaces.clsUsuariosInterface
                {
                    st_NombreUsuario = stNombreUsuario
                };

                DataSet dsConsulta = obRecuperarPasswordController.getConsultaPasswordController(obclsUsuariosInterface);

                string stUsuario = dsConsulta.Tables[0].Rows[0]["RegistroNumero"].ToString();

                txtCodigoUsuario.Text = stUsuario;

                /*Ventanilla.Logica.Clases.clsRadicado obclsRadicado = new Ventanilla.Logica.Clases.clsRadicado();
                Ventanilla.Logica.Interfaces.clsRadicadoInterface obclsRadicadoInterface = new Ventanilla.Logica.Interfaces.clsRadicadoInterface();

                DataSet dsConsulta_Radicado = obclsRadicado.(obclsRadicadoInterface);
                long Codigoradicado = dsConsulta_Radicado.Tables[0].Rows[0]["CodRadicado"]*/

                string stMensaje = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                stMensaje = obclsClientes.stNuevoRadicado(Convert.ToInt64(txtCodigoRadicado.Text), Convert.ToInt64(txtCodigoTercero.Text), Convert.ToInt64(txtCodigoFuncionario.Text), Convert.ToInt64(txtCodigoUsuario.Text), txtFechaRadicado.Text, txtDescripcionRadicado.Text);
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + stMensaje + "', '', 'success')</script>");

                txtCodigoRadicado.Text = "";
                txtCodigoRadicado.Text = "";
                txtCodigoFuncionario.Text = "";
                txtCodigoUsuario.Text = "";
                txtFechaRadicado.Text = "";
                txtDescripcionRadicado.Text = "";
                txtCodigoTercero.Text = "";
            }
            else throw new Exception("No pueden quedar campos vacíos");
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
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