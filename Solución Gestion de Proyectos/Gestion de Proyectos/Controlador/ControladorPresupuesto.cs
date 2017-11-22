using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorPresupuesto
    {
        Connection con = null;
        Presupuesto presupuesto = null;
        DataTable dataTable = null;
        public ControladorPresupuesto(Presupuesto parPresupuesto)
        {
            presupuesto = parPresupuesto;
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
                parParameter[0].SqlValue = presupuesto.nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_proyecto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = presupuesto.id_proyecto;

                con.EjecutarSP("sp_agregarPresupuesto", parParameter);
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
                parParameter[0].ParameterName = "@id_presupuesto";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = presupuesto.id_presupuesto;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = presupuesto.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_proyecto";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = presupuesto.id_proyecto;

                con.EjecutarSP("sp_actualizarPresupuesto", parParameter);
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
                parParameter[0].ParameterName = "@id_presupuesto";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = presupuesto.id_presupuesto;

                con.EjecutarSP("sp_eliminarPresupuesto", parParameter);
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
                dataTable = con.RetornaTabla("sp_consultarTODOSPresupuesto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
