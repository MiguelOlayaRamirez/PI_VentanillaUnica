using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class ActualizarDespacho : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] == null)
                {
                    Response.Redirect("Login.aspx");
                    lblUsuario.Text = Session["Login"].ToString();
                }

        }
        }

        protected void btnActualizarDespacho_Click(object sender, EventArgs e)
        {
            try
            {
               // ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>swal({title: 'Are you sure?', text: 'Your will not be able to recover this imaginary file!', type: 'warning', showCancelButton: true, confirmButtonClass: 'btn-danger', confirmButtonText: 'Yes, delete it!', closeOnConfirm: false},function(){ swal('Deleted!', 'Your imaginary file has been deleted.', 'success'); });</ script>");

                lblMensaje.Text = "";
                Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                lblMensaje.Text = obclsClientes.stActualizarDespacho(Convert.ToInt64(txtCodigoDespacho.Text),txtDescripcionDespacho.Text, txtDestinoDespacho.Text, txtFechaDespacho.Text );
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('"+lblMensaje.Text+" ', '', 'success')</script>");
                txtCodigoDespacho.Text = "";
                txtDescripcionDespacho.Text = "";
                txtDestinoDespacho.Text = "";
                txtFechaDespacho.Text = "";
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script>  swal('Se presento un error', '')) </script>");

                lblMensaje.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtCodigoDespacho.Text = "";
            txtDescripcionDespacho.Text = "";
            txtDestinoDespacho.Text = "";
            txtFechaDespacho.Text = "";
            lblMensaje.Text = "";
        }
    }
}