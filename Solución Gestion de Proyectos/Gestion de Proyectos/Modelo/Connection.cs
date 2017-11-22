using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Modelo
{
    class Connection
    {
        private SqlConnection con = null;
        public SqlCommand cmd = null;
        private SqlDataAdapter sda = null;
        private DataTable dt = null;
        private string connectionString = string.Empty;
        public Connection()
        {
            connectionString = "Data Source = localhost; Initial Catalog = PFN2; User ID = sea; Password = 123qwerty";
        }
        public void EjecutarSP(string nombreSP, SqlParameter[] Parametros)
        {
            try
            {
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                cmd.Parameters.AddRange(Parametros);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                con.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable RetornaUno(string nombreSP, SqlParameter[] parParametros)
        {
            dt = null;
            try
            {
                dt = new DataTable();
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                cmd.Parameters.AddRange(parParametros);
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Dispose();
                cmd.Dispose();
                sda.Dispose();
            }
            return dt;
        }
        public DataTable RetornaTabla(string nombreSP)
        {
            dt = null;
            try
            {
                dt = new DataTable();
                con = new SqlConnection(connectionString);
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Dispose();
                cmd.Dispose();
                sda.Dispose();
            }
            return dt;
        }
    }
}