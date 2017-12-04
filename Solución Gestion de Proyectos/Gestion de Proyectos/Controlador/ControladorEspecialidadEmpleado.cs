using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorEspecialidadEmpleado
    {
        Connection con = null;
        EspecialidadEmpleado especialidadEmpleado = null;
        DataTable dataTable = null;
        public ControladorEspecialidadEmpleado(EspecialidadEmpleado parEspecialidadEmpleado)
        {
            especialidadEmpleado = parEspecialidadEmpleado;
        }
        public void AsignarEspecialidadAEmpleado()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_especialidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = especialidadEmpleado.id_especialidad;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nroInterno";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = especialidadEmpleado.nroInterno;

                con.EjecutarSP("sp_asignarEspecialidadAEmpleado", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DesasignarEspecialidadDeEmpleado()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_especialidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = especialidadEmpleado.id_especialidad;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nroInterno";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = especialidadEmpleado.nroInterno;

                con.EjecutarSP("sp_desasignarEspecialidadDeEmpleado", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarPorEspecialidadesDeEmpleado()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_especialidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = especialidadEmpleado.id_especialidad;

                dataTable = con.RetornaUno("sp_consultarEspecialidadesDeEmpleado", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarPorEspecialidadesSinEmpleado()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_especialidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = especialidadEmpleado.id_especialidad;

                dataTable = con.RetornaUno("sp_consultarEspecialidadesSinEmpleado", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarDisponibilidadEmpleadoPorEspecialidad()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_especialidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = especialidadEmpleado.id_especialidad;

                dataTable = con.RetornaUno("sp_consultarDisponibilidadEmpleadoPorEspecialidad", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}