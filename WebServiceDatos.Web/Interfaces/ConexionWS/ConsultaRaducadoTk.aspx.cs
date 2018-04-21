using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WebServiceDatos.Web.Interfaces.ConexionWS
{
    public partial class ConsultaRaducadoTk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try {
                DataSet dsConsulta= new DataSet();
                wsServicios.ConsultaRadicadoWsSoapClient obConsultaRadicadoWsSoap = new wsServicios.ConsultaRadicadoWsSoapClient();
                obConsultaRadicadoWsSoap.ClientCredentials.UserName.UserName = "DIANA";
                obConsultaRadicadoWsSoap.ClientCredentials.UserName.Password = "12345678";

                wsServicios.clsSeguridad obclsSeguridad = new wsServicios.clsSeguridad();
                {
                    obclsSeguridad.stToken = DateTime.Now.ToString("yyyMMdd");
                };
                string stToken = obConsultaRadicadoWsSoap.AutenticacionUsuario(obclsSeguridad);
                if (stToken.Equals("-1")) throw new Exception("Requiere Validacion");
                obclsSeguridad.AutenticacionToken = stToken;

                dsConsulta= obConsultaRadicadoWsSoap.wsConsultaRadicado(obclsSeguridad, Convert.ToInt64(txtCodigo.Text));

                if (dsConsulta.Tables[0].Rows.Count > 0) gvwDatos.DataSource = dsConsulta;
                else gvwDatos.DataSource = null;
                gvwDatos.DataBind();
            } catch(Exception ex) { Response.Write("<Scrip Language= 'JavaScrip'>parent.alert('" + ex.Message + "');</Scrip>"); }
        }
    }
}