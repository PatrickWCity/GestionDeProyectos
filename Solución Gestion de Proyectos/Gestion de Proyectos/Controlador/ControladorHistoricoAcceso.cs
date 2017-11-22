using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorHistoricoAcceso
    {
        Connection con = null;
        HistoricoAcceso ha = null;
        DataTable dataTable = null;
        public ControladorHistoricoAcceso(HistoricoAcceso parHistoricoAcceso)
        {
            ha = parHistoricoAcceso;
        }
        public DataTable ConsultarHabilitados()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[0];
                dataTable = con.RetornaTabla("sp_consultarUsuariosHabilitados");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarDeshabilitados()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[0];
                dataTable = con.RetornaTabla("sp_consultarUsuariosDeshabilitados");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarHabilitadosPorFecha()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@fechaInicio";
                parParameter[0].SqlDbType = SqlDbType.DateTime;
                parParameter[0].SqlValue = ha.fechaInicio;


                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@fechaFinal";
                parParameter[1].SqlDbType = SqlDbType.DateTime;
                parParameter[1].SqlValue = ha.fechaFinal;

                dataTable = con.RetornaUno("sp_consultarUsuariosHabilitadosPorFecha", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarDeshabilitadosPorFecha()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@fechaInicio";
                parParameter[0].SqlDbType = SqlDbType.DateTime;
                parParameter[0].SqlValue = ha.fechaInicio;


                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@fechaFinal";
                parParameter[1].SqlDbType = SqlDbType.DateTime;
                parParameter[1].SqlValue = ha.fechaFinal;

                dataTable = con.RetornaUno("sp_consultarUsuariosDeshabilitadosPorFecha", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}