using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorCargo
    {
        Connection con = null;
        Cargo cargo = null;
        DataTable dataTable = null;
        public ControladorCargo(Cargo parCargo)
        {
            cargo = parCargo;
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
                parParameter[0].SqlValue = cargo.nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@descripcion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 255;
                if (cargo.descripcion == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = cargo.descripcion;
                }

                con.EjecutarSP("sp_agregarCargo", parParameter);
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
                parParameter[0].ParameterName = "@id_cargo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = cargo.id_cargo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = cargo.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 255;
                if (cargo.descripcion == "")
                {
                    parParameter[2].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[2].SqlValue = cargo.descripcion;
                }

                con.EjecutarSP("sp_actualizarCargo", parParameter);
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
                parParameter[0].ParameterName = "@id_cargo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = cargo.id_cargo;

                con.EjecutarSP("sp_eliminarCargo", parParameter);
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
                parParameter[0].ParameterName = "@id_cargo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                if (cargo.id_cargo == 0)
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlInt32.Null;
                }
                else
                {
                    parParameter[0].SqlValue = cargo.id_cargo;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@palabraClave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                if (cargo.palabraClave == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = cargo.palabraClave;
                }

                dataTable = con.RetornaUno("sp_consultarUnCargo", parParameter);

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
                dataTable = con.RetornaTabla("sp_consultarTODOSCargo");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
