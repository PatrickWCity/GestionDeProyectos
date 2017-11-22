using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
namespace Gestion_de_Proyectos.Controlador
{
    class ControladorModuloPerfil
    {
        Connection con = null;
        ModuloPerfil moduloPerfil = null;
        DataTable dataTable = null;
        public ControladorModuloPerfil(ModuloPerfil parModuloPerfil)
        {
            moduloPerfil = parModuloPerfil;
        }
        public void AsignarModuloAPerfil()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_modulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = moduloPerfil.id_modulo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_perfil";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = moduloPerfil.id_perfil;

                con.EjecutarSP("sp_asignarModuloAPerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DesasignarModuloDePerfil()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_modulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = moduloPerfil.id_modulo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_perfil";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = moduloPerfil.id_perfil;

                con.EjecutarSP("sp_desasignarModuloDePerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarPorModulosDePerfil()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_perfil";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = moduloPerfil.id_perfil;

                dataTable = con.RetornaUno("sp_consultarModulosDePerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarPorModulosSinPerfil()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_perfil";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = moduloPerfil.id_perfil;

                dataTable = con.RetornaUno("sp_consultarModulosSinPerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}