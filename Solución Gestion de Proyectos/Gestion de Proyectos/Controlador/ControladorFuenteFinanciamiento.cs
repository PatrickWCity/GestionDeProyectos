using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorFuenteFinanciamiento
    {
        Connection con = null;
        FuenteFinanciamiento fuenteFinanciamiento = null;
        DataTable dataTable = null;
        public ControladorFuenteFinanciamiento(FuenteFinanciamiento parFuenteFinanciamiento)
        {
            fuenteFinanciamiento = parFuenteFinanciamiento;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nombre";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 60;
                parParameter[0].SqlValue = fuenteFinanciamiento.nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_tff";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = fuenteFinanciamiento.id_tff;

                con.EjecutarSP("sp_agregarFuenteFinanciamiento", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Actualizar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_fuenteFinanciamiento";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = fuenteFinanciamiento.id_fuenteFinanciamiento;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = fuenteFinanciamiento.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_tff";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = fuenteFinanciamiento.id_tff;

                con.EjecutarSP("sp_actualizarFuenteFinanciamiento", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Eliminar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_fuenteFinanciamiento";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = fuenteFinanciamiento.id_fuenteFinanciamiento;

                con.EjecutarSP("sp_eliminarFuenteFinanciamiento", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarPorTodos()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[0];
                dataTable = con.RetornaTabla("sp_consultarTODOSFuenteFinanciamiento");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}