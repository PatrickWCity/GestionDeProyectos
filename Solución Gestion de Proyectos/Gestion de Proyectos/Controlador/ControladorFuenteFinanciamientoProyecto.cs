using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorFuenteFinanciamientoProyecto
    {
        Connection con = null;
        FuenteFinanciamientoProyecto usuarioPerfil = null;
        DataTable dataTable = null;
        public ControladorFuenteFinanciamientoProyecto(FuenteFinanciamientoProyecto parUsuarioPerfil)
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
                parParameter[0].ParameterName = "@id_fuenteFinanciamiento";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.id_fuenteFinanciamiento;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_proyecto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = usuarioPerfil.id_proyecto;

                con.EjecutarSP("sp_asignarFuenteFinanciamientoAProyecto", parParameter);
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
                parParameter[0].ParameterName = "@id_fuenteFinanciamiento";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.id_fuenteFinanciamiento;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_proyecto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = usuarioPerfil.id_proyecto;

                con.EjecutarSP("sp_desasignarFuenteFinanciamientoDeProyecto", parParameter);
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
                parParameter[0].ParameterName = "@id_proyecto";// ver script
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.id_proyecto;

                dataTable = con.RetornaUno("sp_consultarFuenteFinanciamientosDeProyecto", parParameter);
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
                parParameter[0].ParameterName = "@id_proyecto";// ver script
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuarioPerfil.id_proyecto;

                dataTable = con.RetornaUno("sp_consultarFuenteFinanciamientosSinProyecto", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
