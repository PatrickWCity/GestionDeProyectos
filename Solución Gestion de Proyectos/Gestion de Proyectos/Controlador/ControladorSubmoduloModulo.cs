using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorSubmoduloModulo
    {
        Connection con = null;
        SubmoduloModulo submoduloModulo = null;
        DataTable dataTable = null;
        public ControladorSubmoduloModulo(SubmoduloModulo parSubmoduloModulo)
        {
            submoduloModulo = parSubmoduloModulo;
        }
        public void AsignarSubmoduloAModulo()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_modulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = submoduloModulo.id_modulo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_submodulo";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = submoduloModulo.id_submodulo;

                con.EjecutarSP("sp_asignarSubmoduloAModulo", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DesasignarSubmoduloDeModulo()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_modulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = submoduloModulo.id_modulo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_submodulo";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = submoduloModulo.id_submodulo;

                con.EjecutarSP("sp_desasignarSubmoduloDeModulo", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarPorSubmodulosDeModulo()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_modulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = submoduloModulo.id_modulo;

                dataTable = con.RetornaUno("sp_consultarSubmodulosDeModulo", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarPorSubmodulosSinModulo()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_modulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = submoduloModulo.id_modulo;

                dataTable = con.RetornaUno("sp_consultarSubmodulosSinModulo", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}