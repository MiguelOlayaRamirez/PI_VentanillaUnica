using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (Request.Cookies["Token"] != null)
                    txtUsuario.Text = Request.Cookies["Token"].Value;
        }
       

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text)) throw new Exception("¡¡¡El Usuario o Password no pueden estar vacíos!!!");
                Ventanilla.Logica.Clases.clsEncriptacion obclsEncriptacion = new Ventanilla.Logica.Clases.clsEncriptacion();
                lblPassword.Text = obclsEncriptacion.stEncriptar(txtPassword.Text);

                Ventanilla.Logica.Clases.clsProcedure obclsUsuaLogin = new Ventanilla.Logica.Clases.clsProcedure();
                DataSet dsConsulta = obclsUsuaLogin.stLogin(txtUsuario.Text, lblPassword.Text);

                if (dsConsulta.Tables[0].Rows.Count > 0)
                {

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
                }
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('El Usuario o Contraseña no exixsten', '', 'success')</script>");
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
