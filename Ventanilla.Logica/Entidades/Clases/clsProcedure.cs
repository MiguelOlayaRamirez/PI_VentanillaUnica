using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ventanilla.Logica.Clases
{
    public class clsProcedure
    {
       
            string setConexion = "";
            SqlCommand sqlCommand = null;
            SqlConnection sqlConnestion = null;
            SqlParameter sqlParameter = null;
            SqlDataAdapter sqlDataAdapter = null;



            public clsProcedure()
            {

                clsConexion obclsConexion = new clsConexion();
                setConexion = obclsConexion.setGetConexion();

            }


        public string stInsertarClientes(string Identificacion, string setNombres, string setApellidos, string setCargo)
        {
            try
            {
                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("stInsertarClientes", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@nIdentificacion", Identificacion));
                sqlCommand.Parameters.Add(new SqlParameter("@cNombre", setNombres));
                sqlCommand.Parameters.Add(new SqlParameter("@cApellido", setApellidos));
                sqlCommand.Parameters.Add(new SqlParameter("@cCargo ", setCargo));
                sqlParameter = new SqlParameter();

                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }
    
        public string stNuevoRadicado(long CodigoRadicado, long CodigoTercero, long CodigoFuncionario, long CodigoUsuario, string FechaRadicado, string DescripcionRadicado)
    {
        try
        {
            sqlConnestion = new SqlConnection(setConexion);
            sqlConnestion.Open();

            sqlCommand = new SqlCommand("spNuevoRadicado", sqlConnestion);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@CodRadicado", CodigoRadicado));
            sqlCommand.Parameters.Add(new SqlParameter("@CodTercero", CodigoTercero));
            sqlCommand.Parameters.Add(new SqlParameter("@CodAdmon", CodigoFuncionario));
            sqlCommand.Parameters.Add(new SqlParameter("@CodUsuario  ", CodigoUsuario));
                sqlCommand.Parameters.Add(new SqlParameter("@Fecha_Radicado", FechaRadicado));
                sqlCommand.Parameters.Add(new SqlParameter("@DescRadicado ", DescripcionRadicado));
                sqlParameter = new SqlParameter();

            sqlParameter.ParameterName = "@cMensaje";
            sqlParameter.SqlDbType = SqlDbType.VarChar;
            sqlParameter.Size = 100;
            sqlParameter.Direction = ParameterDirection.Output;

            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();

            return sqlParameter.Value.ToString();
        }
        catch (Exception ex) { throw ex; }
        finally { sqlConnestion.Close(); }


    }

        public string stDespachoNuevo(long CodigoRadicado, string Descripcion, string Destino, string FechaDespacho)
        {
            try
            {
                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spDespachoNuevo", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodDespacho", CodigoRadicado));
                sqlCommand.Parameters.Add(new SqlParameter("@DescDespacho", Descripcion));
                sqlCommand.Parameters.Add(new SqlParameter("@DestinoDespacho", Destino));
                sqlCommand.Parameters.Add(new SqlParameter("@Fecha_Despacho  ", FechaDespacho));
                
                sqlParameter = new SqlParameter();

                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }

        public string stActualizarRadicado(long txtCodigoRadicado, long txtCodigoTercero, long txtCodigoAdministrativo,  string txtFechaRadicado, string txtDescripcion, long txtCodigoUsuario )
        {
           

            try
            {
                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spActualizarRadicado", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodRadicado", txtCodigoRadicado));
                sqlCommand.Parameters.Add(new SqlParameter("@CodTercero", txtCodigoTercero));
                sqlCommand.Parameters.Add(new SqlParameter("@CodAdmon", txtCodigoAdministrativo));
                sqlCommand.Parameters.Add(new SqlParameter("@Fecha_Radicado", txtFechaRadicado));
                sqlCommand.Parameters.Add(new SqlParameter("@DescRadicado", txtDescripcion));
                sqlCommand.Parameters.Add(new SqlParameter("@CodUsuario", txtCodigoUsuario));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }

        public DataSet stBuscarRadicado(long txtCodigoRadicado)
        {
            try
            {



                DataSet dsConsulta = null;

                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spBuscarRadicado", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodRadicado", txtCodigoRadicado));
                //sqlCommand.Parameters.Add(new SqlParameter("@CodTercero", txtCodigoTercero));
                //sqlCommand.Parameters.Add(new SqlParameter("@CodAdmon", txtCodigoAdministrativo));
                //sqlCommand.Parameters.Add(new SqlParameter("@Fecha_Radicado", txtFechaRadicado));
                //sqlCommand.Parameters.Add(new SqlParameter("@DescRadicado", txtDescripcion));
                //sqlCommand.Parameters.Add(new SqlParameter("@CodUsuario", txtCodigoUsuario));

                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }
        }

        public string stActualizarDespacho(long txtCodigoDespacho, string txtDescripcionDespacho, string txtDestinoDespacho, string txtFechaDespacho)
        {
 
            try
            {
                
                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spActualizarDespacho", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodDespacho", txtCodigoDespacho));
                sqlCommand.Parameters.Add(new SqlParameter("@DescDespacho", txtDescripcionDespacho));
                sqlCommand.Parameters.Add(new SqlParameter("@DestinoDespacho", txtDestinoDespacho));
                sqlCommand.Parameters.Add(new SqlParameter("@Fecha_Despacho", txtFechaDespacho));
            
                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }

        public DataSet stConsultarTercero(long CodTercero)
        {
            try
            {

                DataSet dsConsulta = new DataSet();

                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("stConsultarTercero", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodTercero", CodTercero));



                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }

        public string stActualizarTercero(long txtCodigoTercero, string TxtTelefono, string txtEmail, string TxtNombre)
        {
           

            try
            {
                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spActualizarTercero", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodTercero", txtCodigoTercero));
                sqlCommand.Parameters.Add(new SqlParameter("@TelTercero", TxtTelefono));
                sqlCommand.Parameters.Add(new SqlParameter("@EmailTercero", txtEmail));
                sqlCommand.Parameters.Add(new SqlParameter("@DescTercero", TxtNombre));



                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }

        public string stEliminarTercero(long txtCodigoTercero)
        {
            try
            {
                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spEliminarTercero", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodTercero", txtCodigoTercero));


                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }

        public string stInsertarTercero(long txtCodigoTercero, string TxtTelefono, string txtEmail, string TxtNombre)
        {


            try
            {
                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spInsertarTercero", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodTercero", txtCodigoTercero));
                sqlCommand.Parameters.Add(new SqlParameter("@TelTercero", TxtTelefono));
                sqlCommand.Parameters.Add(new SqlParameter("@EmailTercero", txtEmail));
                sqlCommand.Parameters.Add(new SqlParameter("@DescTercero ", TxtNombre));

                
                sqlParameter = new SqlParameter();

                sqlParameter.ParameterName = "@cMensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 100;
                sqlParameter.Direction = ParameterDirection.Output;

                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { sqlConnestion.Close(); }


        }

        public DataSet stLogin(string stLogin, string stPassword)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                sqlConnestion = new SqlConnection(setConexion);
                sqlConnestion.Open();

                sqlCommand = new SqlCommand("spLogin", sqlConnestion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add(new SqlParameter("@CodUsuario", stPassword));
                sqlCommand.Parameters.Add(new SqlParameter("@NomUsuario", stLogin));

                //sqlParameter.ParameterName = "@cMensaje";
                //sqlParameter.SqlDbType = SqlDbType.VarChar;
                //sqlParameter.Size = 100;
                //sqlParameter.Direction = ParameterDirection.Output;

                //sqlCommand.Parameters.Add(sqlParameter);

                sqlCommand.ExecuteNonQuery();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;

            }
            catch (Exception ex) { throw ex; }


        }

    }
}