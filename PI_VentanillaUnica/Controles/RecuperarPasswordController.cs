using System;
using System.Data;

namespace PI_VentanillaUnica.Controles
{
    public class RecuperarPasswordController
    {
        public DataSet getConsultaPasswordController(Ventanilla.Logica.Interfaces.clsUsuariosInterface obclsUsuariosInterface)
        {
            try
            {
                Ventanilla.Logica.Clases.clsRecuperarPassword obclsRecuperarPassword = new Ventanilla.Logica.Clases.clsRecuperarPassword();
                return obclsRecuperarPassword.getConsultaPassword(obclsUsuariosInterface);
            }
            catch (Exception ex) { throw ex; }
        }

        public void setMailController(Ventanilla.Logica.Modelo.clsEmail obclsEmail)
        {
            try
            {
                Ventanilla.Logica.Clases.clsGeneralEnvioCorreo obclsGeneralEnvioCorreo = new Ventanilla.Logica.Clases.clsGeneralEnvioCorreo();
                obclsGeneralEnvioCorreo.setEmail(obclsEmail);

            }
            catch (Exception ex) { throw ex; }

        }
    }
}
