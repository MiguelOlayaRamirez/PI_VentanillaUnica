using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
            if (!IsPostBack)
            {
                if (Session["sessionEmail"] == null)
                {
                    Response.Redirect("../Interfaces/Login.aspx");
                }
            }
        }

        protected void imaOkUsuario_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoUsuario.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtApellidosUsuario.Text) || string.IsNullOrEmpty(txtCargoUsuario.Text)) throw new Exception("No pueden quedar campos vacíos");

                Controles.RecuperarPasswordController obRecuperarPasswordController = new Controles.RecuperarPasswordController();
                Ventanilla.Logica.Interfaces.clsUsuariosInterface obclsUsuariosInterface = new Ventanilla.Logica.Interfaces.clsUsuariosInterface
                {
                    st_NombreUsuario = txtNombreUsuario.Text,
                    st_ApellidoUsuario = txtApellidosUsuario.Text,
                    st_CodigoUsuario = txtCodigoUsuario.Text,
                    st_CargoUsuario = txtCargoUsuario.Text
                };
                DataSet dsConsulta = obRecuperarPasswordController.getConsultaPasswordController(obclsUsuariosInterface);

                if (dsConsulta.Tables[0].Rows.Count <= 0)
                {
                    Ventanilla.Logica.Clases.clsEncriptacion obclsEncriptacion = new Ventanilla.Logica.Clases.clsEncriptacion();
                    //string Password = obclsEncriptacion.stEncriptar(txtCodigoUsuario.Text);
                    string stKey = ConfigurationManager.AppSettings["stKey"];

                    string Encripted = obclsEncriptacion.stEncriptar3DES(txtCodigoUsuario.Text, stKey);
                    //string Decripted = obclsEncriptacion.stDesencriptar3DES(Encripted, stKey);//Para desencriptar

                    lblMensaje.Text = "";
                    Ventanilla.Logica.Clases.clsProcedure obclsClientes = new Ventanilla.Logica.Clases.clsProcedure();
                    lblMensaje.Text = obclsClientes.stInsertarClientes(Encripted, txtNombreUsuario.Text, txtApellidosUsuario.Text, txtCargoUsuario.Text);
                }
                else throw new Exception("Ya hay una cuenta asociada a ese Email. Si no la recuerda por favor dé clic en ¿Olvidó su Password?" + " del Menú Login");
            }
            catch (Exception ex) { Response.Write("<script Language='JavaScript'>parent.alert('" + "¡¡¡  " + ex.Message + " !!!" + "');</Script>"); }
        }

        protected void imaCancelUsuario_Click(object sender, ImageClickEventArgs e)
        {
            txtCodigoUsuario.Text = txtNombreUsuario.Text = txtApellidosUsuario.Text = txtCargoUsuario.Text = "";
        }
    }
}