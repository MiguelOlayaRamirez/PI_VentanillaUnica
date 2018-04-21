using System;
using System.Data;
using System.Data.SqlClient;

namespace Ventanilla.Logica.Clases
{
    public class clsRadicadoAutocompletar
    {
        string stConexion;
        SqlConnection _SqlConnection = null;
        SqlCommand _SqlCommand = null;
        SqlDataAdapter _SqlDataAdapter = null;

        public clsRadicadoAutocompletar()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.setGetConexion();
        }

        public DataSet dsConsultarRadicado(long lnCodigo)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spBuscarRadicado_Autocompletar", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@CodRadicado", lnCodigo));
                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
