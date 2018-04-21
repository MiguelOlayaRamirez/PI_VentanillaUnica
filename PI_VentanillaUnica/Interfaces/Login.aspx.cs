using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               if (Request.Cookies["Token"] != null)
                  txtUsuario.Text = Request.Cookies["Token"].Value.ToString();
            }  
        }        

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Response.Redirect("NuevoRadicado.aspx?usuario=" + txtUsuario.Text);

                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text)) throw new Exception("¡¡¡El Usuario o Password no pueden estar vacíos!!!");
                Ventanilla.Logica.Clases.clsEncriptacion obclsEncriptacion = new Ventanilla.Logica.Clases.clsEncriptacion();
                //string Password = obclsEncriptacion.stEncriptar(txtPassword.Text);
                string stKey = ConfigurationManager.AppSettings["stKey"];

                string Encripted = obclsEncriptacion.stEncriptar3DES(txtPassword.Text, stKey);
                //string Decripted = obclsEncriptacion.stDesencriptar3DES(Encripted, stKey);     

                Ventanilla.Logica.Clases.clsProcedure obclsUsuaLogin = new Ventanilla.Logica.Clases.clsProcedure();
                DataSet dsConsulta = obclsUsuaLogin.stLogin(txtUsuario.Text, Encripted);

                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    Session["sessionEmail"] = txtUsuario.Text;

                    if (chkRecordar.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("Token", txtUsuario.Text);
                        cookie.Expires = DateTime.Now.AddDays(2);
                        this.Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("Token", txtUsuario.Text);
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        this.Response.Cookies.Add(cookie);
                    }

                    Session["Login"] = txtUsuario.Text;

                    Response.Redirect("NuevoRadicado.aspx");

                    //Response.Redirect("NuevoRadicado.aspx?stEmail=" + txtUsuario.Text); Con este código se envía información a otro formulario, en este caso a NuevoRadicado
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('No se encuentra usuario registrado con ese correo', '', 'success')</script>");
                    txtPassword.Text = "";
                    txtUsuario.Text = "";
            }
            catch (Exception ex)
            {
                Response.Write("<script Language='JavaScript'>parent.alert('" + ex.Message + "');</script>");
            }
        }
    }
}
