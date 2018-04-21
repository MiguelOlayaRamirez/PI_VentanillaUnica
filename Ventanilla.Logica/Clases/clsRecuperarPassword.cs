using System;
using System.Data;
using System.Data.SqlClient;

namespace Ventanilla.Logica.Clases
{
    public class clsRecuperarPassword
    {
        SqlConnection _SqlConnection = null; //Me permite establecer comunicación con BBDD
        SqlCommand _SqlCommand = null; //Me permite ejecutar comandos SQL
        SqlDataAdapter _SqlDataAdapter = null; //Me permite adaptar conjunto de datos SQL
        string stConexion = string.Empty; // Cadena de Conexión
        SqlParameter _SqlParameter = null;

        public clsRecuperarPassword()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.setGetConexion();
        }

        public DataSet getConsultaPassword(Interfaces.clsUsuariosInterface obclsUsuarioInterface)
        {
            try
            {
                DataSet dsConsulta = new DataSet();
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarPassword", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@NomUsuario", obclsUsuarioInterface.st_NombreUsuario));

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;


            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
