using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;
namespace Gestion_de_Proyectos.Controlador
{
    class ControladorEmpleadoProyecto
    {
        Connection con = null;
        EmpleadoProyecto empleadoProyecto = null;
        DataTable dataTable = null;
        public ControladorEmpleadoProyecto(EmpleadoProyecto parEmpleadoProyecto)
        {
            empleadoProyecto = parEmpleadoProyecto;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = empleadoProyecto.nroInterno;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_proyecto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = empleadoProyecto.id_proyecto;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_cargo";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = empleadoProyecto.id_cargo;

                con.EjecutarSP("sp_agregarEmpleadoProyecto", parParameter);
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

                SqlParameter[] parParameter = new SqlParameter[4];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_ep";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = empleadoProyecto.id_ep;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nroInterno";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = empleadoProyecto.nroInterno;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_proyecto";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = empleadoProyecto.id_proyecto;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@id_cargo";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = empleadoProyecto.id_cargo;

                con.EjecutarSP("sp_actualizarEmpleadoProyecto", parParameter);
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
                parParameter[0].ParameterName = "@id_ep";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = empleadoProyecto.id_ep;

                con.EjecutarSP("sp_eliminarEmpleadoProyecto", parParameter);
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
                dataTable = con.RetornaTabla("sp_consultarTODOSEmpleadoProyecto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }

        public DataTable ConsultarCantidadDeProyectoPorEmpleado()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = empleadoProyecto.nroInterno;

                dataTable = con.RetornaUno("sp_consultarCantidadDeProyectoPorEmpleado", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarCantidadDeProyectoPorCargo()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_cargo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = empleadoProyecto.id_cargo;

                dataTable = con.RetornaUno("sp_consultarCantidadDeProyectoPorCargo", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}