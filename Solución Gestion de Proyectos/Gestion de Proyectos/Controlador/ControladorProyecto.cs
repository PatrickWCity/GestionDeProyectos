using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorProyecto
    {
        Connection con = null;
        Proyecto proyecto = null;
        DataTable dataTable = null;
        public ControladorProyecto(Proyecto parProyecto)
        {
            proyecto = parProyecto;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_cliente";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = proyecto.id_cliente;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = proyecto.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_presupuesto";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = proyecto.id_presupuesto;

                con.EjecutarSP("sp_agregarProyecto", parParameter);
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
                parParameter[0].ParameterName = "@id_proyecto";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = proyecto.id_proyecto;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = proyecto.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@id_cliente";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = proyecto.id_cliente;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@id_presupuesto";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = proyecto.id_presupuesto;

                con.EjecutarSP("sp_actualizarProyecto", parParameter);
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
                parParameter[0].ParameterName = "@id_proyecto";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = proyecto.id_proyecto;

                con.EjecutarSP("sp_eliminarProyecto", parParameter);
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
                dataTable = con.RetornaTabla("sp_consultarTODOSProyecto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}