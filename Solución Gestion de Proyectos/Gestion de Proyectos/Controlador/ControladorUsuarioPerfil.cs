using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorUsuarioPerfil
    {
        Connection con = null;
        UsuarioPerfil usuarioPerfil = null;
        DataTable dataTable = null;
        public ControladorUsuarioPerfil(UsuarioPerfil parUsuarioPerfil)
        {
            usuarioPerfil = parUsuarioPerfil;
        }
        public void AsignarUsuarioAPerfil()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.nroInterno;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_perfil";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = usuarioPerfil.id_perfil;

                con.EjecutarSP("sp_asignarUsuarioAPerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DesasignarUsuarioDePerfil()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.nroInterno;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_perfil";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = usuarioPerfil.id_perfil;

                con.EjecutarSP("sp_desasignarUsuarioDePerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarPorUsuariosDePerfil()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_perfil";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.id_perfil;

                dataTable = con.RetornaUno("sp_consultarUsuariosDePerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarPorUsuariosSinPerfil()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_perfil";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.id_perfil;

                dataTable = con.RetornaUno("sp_consultarUsuariosSinPerfil", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}