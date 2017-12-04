using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorGastoEjecutado
    {
        Connection con = null;
        GastoEjecutado gastoEjecutado = null;
        DataTable dataTable = null;
        public ControladorGastoEjecutado(GastoEjecutado parGastoEjecutado)
        {
            gastoEjecutado = parGastoEjecutado;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_item";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = gastoEjecutado.id_item;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@monto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = gastoEjecutado.monto;

                con.EjecutarSP("sp_agregarGastoEjecutado", parParameter);
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
                parParameter[0].ParameterName = "@id_gastoEjecutado";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = gastoEjecutado.id_gastoEjecutado;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_item";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = gastoEjecutado.id_item;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@monto";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = gastoEjecutado.monto;

                con.EjecutarSP("sp_actualizarGastoEjecutado", parParameter);
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
                parParameter[0].ParameterName = "@id_gastoEjecutado";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = gastoEjecutado.id_gastoEjecutado;

                con.EjecutarSP("sp_eliminarGastoEjecutado", parParameter);
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
                dataTable = con.RetornaTabla("sp_consultarTODOSGastoEjecutado");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}