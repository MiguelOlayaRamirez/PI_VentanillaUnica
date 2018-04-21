using System;
using System.Data;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class CrudTerceros : System.Web.UI.Page
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                DataSet dsConsulta = obclsClientes.stConsultarTercero(Convert.ToInt64(txtCodigoTercero.Text));
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");

                if (dsConsulta.Tables[0].Rows.Count == 0) gvwDatos.DataSource = null;
                else gvwDatos.DataSource = dsConsulta;
                gvwDatos.DataBind();



            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");

            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stActualizarTercero(Convert.ToInt64(txtCodigoTercero.Text), TxtTelefono.Text, txtEmail.Text, TxtNombre.Text);
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
                txtCodigoTercero.Text = "";
                TxtTelefono.Text = "";
                txtEmail.Text = "";
                TxtNombre.Text = "";

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stEliminarTercero(Convert.ToInt64(txtCodigoTercero.Text));
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
                txtCodigoTercero.Text = "";
                TxtTelefono.Text = "";
                txtEmail.Text = "";
                TxtNombre.Text = "";

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stInsertarTercero(Convert.ToInt64(txtCodigoTercero.Text), TxtTelefono.Text, txtEmail.Text, TxtNombre.Text);
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
                txtCodigoTercero.Text = "";
                TxtTelefono.Text = "";
                txtEmail.Text = "";
                TxtNombre.Text = "";
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
            }
        }
    }
    }
