using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventanilla.Logica.Clases
{
    public class clsUsuarios
    {
        public string stInsertarUsuario(long ln_Codigo,
            string stNombresUsuario,
            string stApellidosUsuarios,
            string stCargoUsuario)
        {
            try 
            {
                using (Entidades.Cnx obCnx = new Entidades.Cnx())
                {
                    Entidades.Usuarios obUsuarios = new Entidades.Usuarios
                    {
                        CodUsuario = ln_Codigo,
                        NomUsuario = stNombresUsuario,
                        ApeUsuario = stApellidosUsuarios,
                        CargoUsuario = stCargoUsuario
                    };
                    obCnx.Usuarios.Add(obUsuarios);
                    obCnx.SaveChanges();
                }
            }
            catch (Exception ex) { throw ex; }
            return "Proceso Realizado con Éxito";
        }
    }
}
