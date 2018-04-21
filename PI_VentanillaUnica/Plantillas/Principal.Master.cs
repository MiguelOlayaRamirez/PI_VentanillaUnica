using System;
using System.Data;

namespace PI_VentanillaUnica.Plantillas
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string stNombreUsuario = null;

                if (Session["sessionEmail"] != null)
                {
                    stNombreUsuario = Session["sessionEmail"].ToString();

                    Controles.RecuperarPasswordController obRecuperarPasswordController = new Controles.RecuperarPasswordController();
                    Ventanilla.Logica.Interfaces.clsUsuariosInterface obclsUsuariosInterface = new Ventanilla.Logica.Interfaces.clsUsuariosInterface
                    {
                        st_NombreUsuario = stNombreUsuario
                    };

                    DataSet dsConsulta = obRecuperarPasswordController.getConsultaPasswordController(obclsUsuariosInterface);

                    string stUsuario = dsConsulta.Tables[0].Rows[0]["ApeUsuario"].ToString();

                    lblUsuario.Text = stUsuario;
                }
                else
                    Response.Redirect("../Interfaces/Login.aspx");
            }
        }

        protected void btSalir_Click(object sender, EventArgs e)
        {
            //Session.Remove("sessionEmail"); //Elimina una variable de sesion en específico
            Session.RemoveAll();
            Response.Redirect("../Interfaces/Login.aspx");
        }
    }
}



