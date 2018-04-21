using System;
using System.Data;
using System.Data.SqlClient;

namespace Ventanilla.Logica.Clases
{
    public class clsTerceroAutocompletar
    {
        string stConexion;
        SqlConnection _SqlConnection = null;
        SqlCommand _SqlCommand = null;
        SqlDataAdapter _SqlDataAdapter = null;

        public clsTerceroAutocompletar()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.setGetConexion();

        }

        public DataSet dsConsultarTercero (long lnCodigo)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarTercero_Autocompletar", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@CodTercero", lnCodigo));
                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            
        }
    }
}
