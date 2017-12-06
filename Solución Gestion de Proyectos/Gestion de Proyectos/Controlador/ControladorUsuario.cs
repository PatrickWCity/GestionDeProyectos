using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorUsuario
    {
        Connection con = null;
        Usuario usuario = null;
        DataTable dataTable = null;
        public ControladorUsuario(Usuario parUsuario)
        {
            usuario = parUsuario;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@run";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].Size = 10;
                if (usuario.run == "")
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[0].SqlValue = usuario.run;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = usuario.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@appat";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 60;
                parParameter[2].SqlValue = usuario.appat;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@apmat";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 60;
                if (usuario.apmat == "")
                {
                    parParameter[3].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[3].SqlValue = usuario.apmat;
                }

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@direccion";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 255;
                parParameter[4].SqlValue = usuario.direccion;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@id_localidad";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = usuario.id_localidad;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@telefono";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = usuario.telefono;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@email";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 255;
                parParameter[7].SqlValue = usuario.email;

                con.EjecutarSP("sp_agregarUsuario", parParameter);
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

                SqlParameter[] parParameter = new SqlParameter[9];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuario.nroInterno;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@run";
                parParameter[1].SqlDbType = SqlDbType.Char;
                parParameter[1].Size = 10;
                if (usuario.run == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = usuario.run;
                }

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 60;
                parParameter[2].SqlValue = usuario.nombre;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@appat";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 60;
                parParameter[3].SqlValue = usuario.appat;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@apmat";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 60;
                if (usuario.apmat== "")
                {
                    parParameter[4].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[4].SqlValue = usuario.apmat;
                }

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@direccion";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 255;
                parParameter[5].SqlValue = usuario.direccion;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@id_localidad";
                parParameter[6].SqlDbType = SqlDbType.Int;
                parParameter[6].SqlValue = usuario.id_localidad;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@telefono";
                parParameter[7].SqlDbType = SqlDbType.Int;
                parParameter[7].SqlValue = usuario.telefono;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@email";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 255;
                parParameter[8].SqlValue = usuario.email;


                con.EjecutarSP("sp_actualizarUsuario", parParameter);
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
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = usuario.nroInterno;

                con.EjecutarSP("sp_eliminarUsuario", parParameter);
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
                parParameter[0].ParameterName = "@nroInterno";
                parParameter[0].SqlDbType = SqlDbType.Int;
                if (usuario.nroInterno == 0)
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlInt32.Null;
                }
                else
                {
                    parParameter[0].SqlValue = usuario.nroInterno;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@palabraClave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                if (usuario.palabraClave == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = usuario.palabraClave;
                }

                dataTable = con.RetornaUno("sp_consultarUnUsuario", parParameter);

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
                dataTable = con.RetornaTabla("sp_consultarTODOSUsuario");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}