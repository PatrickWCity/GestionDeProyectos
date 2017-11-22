using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorLocalidad
    {
        Connection con = null;
        Localidad localidad = null;
        DataTable dataTable = null;
        public ControladorLocalidad(Localidad parLocalidad)
        {
            localidad = parLocalidad;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[3];


                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@region";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 60;
                parParameter[0].SqlValue = localidad.region;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@providencia";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = localidad.providencia;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@comuna";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 60;
                parParameter[2].SqlValue = localidad.comuna;

                con.EjecutarSP("sp_agregarLocalidad", parParameter);
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
                parParameter[0].ParameterName = "@id_localidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = localidad.id_localidad;
                
                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@region";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = localidad.region;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@providencia";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 60;
                parParameter[2].SqlValue = localidad.providencia;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@comuna";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 60;
                parParameter[3].SqlValue = localidad.comuna;

                con.EjecutarSP("sp_actualizarLocalidad", parParameter);
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
                parParameter[0].ParameterName = "@id_localidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = localidad.id_localidad;

                con.EjecutarSP("sp_eliminarLocalidad", parParameter);
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
                parParameter[0].ParameterName = "@id_localidad";
                parParameter[0].SqlDbType = SqlDbType.Int;
                if (localidad.id_localidad == 0)
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlInt32.Null;
                }
                else
                {
                    parParameter[0].SqlValue = localidad.id_localidad;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@palabraClave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                if (localidad.palabraClave == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = localidad.palabraClave;
                }

                dataTable = con.RetornaUno("sp_consultarUnLocalidad", parParameter);

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
                dataTable = con.RetornaTabla("sp_consultarTODOSLocalidad");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
