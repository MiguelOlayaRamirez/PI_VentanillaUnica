using System;
using System.Configuration;
using System.Data;

namespace PI_VentanillaUnica.Interfaces
{
    public partial class frmRestaurarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese email,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                Controles.RecuperarPasswordController obRecuperarPasswordController = new Controles.RecuperarPasswordController();
                Ventanilla.Logica.Interfaces.clsUsuariosInterface obclsUsuariosInterface = new Ventanilla.Logica.Interfaces.clsUsuariosInterface
                {
                    st_NombreUsuario = txtEmail.Text
                };

                DataSet dsConsulta = obRecuperarPasswordController.getConsultaPasswordController(obclsUsuariosInterface);

                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    string[] stUsuario = dsConsulta.Tables[0].Rows[0]["NomUsuario"].ToString().Split('@');
                    string stCodUsuario = dsConsulta.Tables[0].Rows[0]["CodUsuario"].ToString();
                    
                    Ventanilla.Logica.Clases.clsEncriptacion obclsEncriptacion = new Ventanilla.Logica.Clases.clsEncriptacion();
                    string stKey = ConfigurationManager.AppSettings["stKey"];

                    //string Encripted = obclsEncriptacion.stEncriptar3DES(stCodUsuario, stKey);
                    string Decripted = obclsEncriptacion.stDesencriptar3DES(stCodUsuario, stKey);


                    string stCuerpoHTML = "<!DOCTYPE html>";
                    stCuerpoHTML += "<html lang='es'>";
                    stCuerpoHTML += "<head>";
                    stCuerpoHTML += "<meta charset='utf - 8'>";
                    stCuerpoHTML += "<title>Recuperación de Contraseña</title>";
                    stCuerpoHTML += "</head>";
                    stCuerpoHTML += "<body style='background - color: black'>";
                    stCuerpoHTML += "<table style='max - width:600px; padding:10px; margin: 0 auto; border - collapse: collapse;'> ";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='padding: 0'>";
                    stCuerpoHTML += "<img style='padding: 0; display: block' src='cid:Fondo' width='100%' height='10%'>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='background - color: #ecf0fi'>";
                    stCuerpoHTML += "<div style='color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family:sans-serif'>";
                    stCuerpoHTML += "<h2 style='color: #e67e22; margin: 0 0 7px'>Hola "+ stUsuario[0] + "</h2>";
                    stCuerpoHTML += "<p style='margin: 2px; font - size: 15px'>";
                    stCuerpoHTML += "Hemos recibido una solicitud para reestablecer el password de su cuenta asociada con ";
                    stCuerpoHTML += "ésta dirección de correo electrónico. Si no ha realizado esta solicitud, puede ignorar este ";
                    stCuerpoHTML += "correo electrónico y le garantizamos que su cuenta es completamente segura.";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "Su password es: "+ Decripted;
                    stCuerpoHTML += "</p>";
                    stCuerpoHTML += "<p style='color: #b3b3b3; font - size: 12px; text-align: center; margin: 30px 0 0'>Copyright © Advance - Ventanilla Única 2018</p>";
                    stCuerpoHTML += "</div>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "</table>";
                    stCuerpoHTML += "</body>";
                    stCuerpoHTML += "</html>";


                    Ventanilla.Logica.Modelo.clsEmail obclsEmail = new Ventanilla.Logica.Modelo.clsEmail
                    {
                        //Email: noreplyadvanceventanillaunica@gmail.com
                        //Password: Ventanillapi2018

                        stServidor = ConfigurationManager.AppSettings["stServidor"].ToString(),
                        stusuario = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stPassword = ConfigurationManager.AppSettings["stPassword"].ToString(),
                        stPuerto = ConfigurationManager.AppSettings["stPuerto"].ToString(),
                        blAutenticacion = true,
                        blConexionSegura = true,
                        inPrioridad = 0,//Prioridad Normal
                        inTipo = 1,//html
                        stAsunto = "Recuperación de Password",
                        stFrom = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stTo = txtEmail.Text,
                        stImagen = Server.MapPath("~") + @"\Imagenes\Ventanilla única.jpg",
                        stIdImagen = "Fondo",
                        stMensaje = stCuerpoHTML
                    };

                    obRecuperarPasswordController.setMailController(obclsEmail);
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', 'Se realizó proceso con éxito!', 'success') </script>");


                }
                else throw new Exception("No se encontró información asociada a la dirección de correo");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}