using System;
using System.Windows.Forms;


namespace PI_VentanillaUnica.Interfaces
{
    public partial class Despacho : System.Web.UI.Page
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

        protected void txtGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtCodigoDespacho.Text))
                {

                    MessageBox.Show("Debe completar la informacion");
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Debe completar la informacion', '', 'success')</script");


                    return;
                }

                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stDespachoNuevo(Convert.ToInt64(txtCodigoDespacho.Text), txtDescripcion.Text, txtDestino.Text, txtFechaDespacho.Text);

                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('" + lblMensaje.Text + "', '', 'success')</script>");
                txtCodigoDespacho.Text = "";
                txtDescripcion.Text = "";
                txtDestino.Text = "";
                txtFechaDespacho.Text = "";

            }
            catch (Exception ex) { throw ex; }
        }

        protected void txtCancelar_Click(object sender, EventArgs e)
        {
            txtCodigoDespacho.Text = "";
            txtDescripcion.Text = "";
            txtDestino.Text = "";
            txtFechaDespacho.Text = "";

        }
    }
}