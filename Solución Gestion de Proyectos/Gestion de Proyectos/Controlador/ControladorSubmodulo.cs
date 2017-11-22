using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorSubmodulo
    {
        Connection con = null;
        Submodulo submodulo = null;
        DataTable dataTable = null;
        public ControladorSubmodulo(Submodulo parSubmodulo)
        {
            submodulo = parSubmodulo;
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
                parParameter[0].Size = 255;
                parParameter[0].SqlValue = submodulo.nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@descripcion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 255;
                if (submodulo.descripcion == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = submodulo.descripcion;
                }

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@ubicacion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 255;
                parParameter[2].SqlValue = submodulo.ubicacion;

                con.EjecutarSP("sp_agregarSubmodulo", parParameter);
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
                parParameter[0].ParameterName = "@id_submodulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = submodulo.id_submodulo;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 255;
                parParameter[1].SqlValue = submodulo.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 255;
                if (submodulo.descripcion == "")
                {
                    parParameter[2].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[2].SqlValue = submodulo.descripcion;
                }

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@ubicacion";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 255;
                parParameter[3].SqlValue = submodulo.ubicacion;

                con.EjecutarSP("sp_actualizarSubmodulo", parParameter);
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
                parParameter[0].ParameterName = "@id_submodulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = submodulo.id_submodulo;

                con.EjecutarSP("sp_eliminarSubmodulo", parParameter);
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
                parParameter[0].ParameterName = "@id_submodulo";
                parParameter[0].SqlDbType = SqlDbType.Int;
                if (submodulo.id_submodulo == 0)
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlInt32.Null;
                }
                else
                {
                    parParameter[0].SqlValue = submodulo.id_submodulo;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@palabraClave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                if (submodulo.palabraClave == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = submodulo.palabraClave;
                }

                dataTable = con.RetornaUno("sp_consultarUnSubmodulo", parParameter);

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
                dataTable = con.RetornaTabla("sp_consultarTODOSSubmodulo");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}