using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorTipoFuenteFinanciamiento
    {
        Connection con = null;
        TipoFuenteFinanciamiento tipoFuenteFinanciamiento = null;
        DataTable dataTable = null;
        public ControladorTipoFuenteFinanciamiento(TipoFuenteFinanciamiento parTipoFuenteFinanciamiento)
        {
            tipoFuenteFinanciamiento = parTipoFuenteFinanciamiento;
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
                parParameter[0].Size = 255;
                parParameter[0].SqlValue = tipoFuenteFinanciamiento.nombre;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@descripcion";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 255;
                if (tipoFuenteFinanciamiento.descripcion == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = tipoFuenteFinanciamiento.descripcion;
                }

                con.EjecutarSP("sp_agregarTipoFuenteFinanciamiento", parParameter);
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
                parParameter[0].ParameterName = "@id_tff";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = tipoFuenteFinanciamiento.id_tff;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 255;
                parParameter[1].SqlValue = tipoFuenteFinanciamiento.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@descripcion";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 255;
                if (tipoFuenteFinanciamiento.descripcion == "")
                {
                    parParameter[2].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[2].SqlValue = tipoFuenteFinanciamiento.descripcion;
                }

                con.EjecutarSP("sp_actualizarTipoFuenteFinanciamiento", parParameter);
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
                parParameter[0].ParameterName = "@id_tff";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = tipoFuenteFinanciamiento.id_tff;

                con.EjecutarSP("sp_eliminarTipoFuenteFinanciamiento", parParameter);
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
                parParameter[0].ParameterName = "@id_tff";
                parParameter[0].SqlDbType = SqlDbType.Int;
                if (tipoFuenteFinanciamiento.id_tff == 0)
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlInt32.Null;
                }
                else
                {
                    parParameter[0].SqlValue = tipoFuenteFinanciamiento.id_tff;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@palabraClave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                if (tipoFuenteFinanciamiento.palabraClave == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = tipoFuenteFinanciamiento.palabraClave;
                }

                dataTable = con.RetornaUno("sp_consultarUnTipoFuenteFinanciamiento", parParameter);

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
                dataTable = con.RetornaTabla("sp_consultarTODOSTipoFuenteFinanciamiento");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarProyectosRangoMontoFuenteFinanciamiento()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_tff";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = tipoFuenteFinanciamiento.id_tff;


                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@monto1";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = tipoFuenteFinanciamiento.monto1;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@monto2";
                parParameter[2].SqlDbType = SqlDbType.Int;
                parParameter[2].SqlValue = tipoFuenteFinanciamiento.monto2;

                dataTable = con.RetornaUno("sp_consultarProyectosRangoMontoTipoFuenteFinanciamiento", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
