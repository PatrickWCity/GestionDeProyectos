using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorAcceso
    {
        Connection con = null;
        Acceso a = null;
        DataTable dataTable = null;
        public ControladorAcceso(Acceso parAcceso)
        {
            a = parAcceso;
        }
        public void ActualizarClave()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@username";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 20;
                parParameter[0].SqlValue = a.username;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@claveActual";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = a.clave;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@claveNueva";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 20;
                parParameter[2].SqlValue = a.claveNueva;

                con.EjecutarSP("sp_actualizarClave", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ConsultaAccesoExisteUsername()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@username";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 20;
                parParameter[0].SqlValue = a.username;

                dataTable = con.RetornaUno("sp_consultaAccesoExisteUsername", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultaAcceso()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@username";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 20;
                parParameter[0].SqlValue = a.username;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@clave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = a.clave;

                dataTable = con.RetornaUno("sp_consultaAcceso", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }

        public DataTable ConsultaAccesoHabilitado()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@username";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 20;
                parParameter[0].SqlValue = a.username;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@clave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = a.clave;

                dataTable = con.RetornaUno("sp_consultaAccesoHabilitado", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultaAccesoPrimero()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@username";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 20;
                parParameter[0].SqlValue = a.username;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@clave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = a.clave;

                dataTable = con.RetornaUno("sp_consultaAccesoPrimera", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultaAccesoFechaCad()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@username";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 20;
                parParameter[0].SqlValue = a.username;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@clave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = a.clave;

                dataTable = con.RetornaUno("sp_consultaAccesoFechaCad", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public void HabilitarAcceso()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = a.nroInterno;

                con.EjecutarSP("sp_habilitarAcceso", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeshabilitarAcceso()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = a.nroInterno;

                con.EjecutarSP("sp_deshabilitarAcceso", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
