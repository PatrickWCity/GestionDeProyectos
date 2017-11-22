using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorItem
    {
        Connection con = null;
        Item item = null;
        DataTable dataTable = null;
        public ControladorItem(Item parItem)
        {
            item = parItem;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nombre";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 60;
                parParameter[0].SqlValue = item.nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@descripcion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 255;
                if (item.descripcion == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = item.descripcion;
                }

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@monto";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = item.monto;

                con.EjecutarSP("sp_agregarItem", parParameter);
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
                parParameter[0].ParameterName = "@id_item";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = item.id_item;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 255;
                parParameter[1].SqlValue = item.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 255;
                if (item.descripcion == "")
                {
                    parParameter[2].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[2].SqlValue = item.descripcion;
                }

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@monto";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = item.monto;

                con.EjecutarSP("sp_actualizarItem", parParameter);
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
                parParameter[0].ParameterName = "@id_item";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = item.id_item;

                con.EjecutarSP("sp_eliminarItem", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarPorUno()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_item";
                parParameter[0].SqlDbType = SqlDbType.Int;
                if (item.id_item == 0)
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlInt32.Null;
                }
                else
                {
                    parParameter[0].SqlValue = item.id_item;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@palabraClave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                if (item.palabraClave == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = item.palabraClave;
                }

                dataTable = con.RetornaUno("sp_consultarUnItem", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarPorTodos()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[0];
                dataTable = con.RetornaTabla("sp_consultarTODOSItem");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
