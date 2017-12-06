using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorCliente
    {
        Connection con = null;
        Cliente cliente = null;
        DataTable dataTable = null;
        public ControladorCliente(Cliente parCliente)
        {
            cliente = parCliente;
        }
        public void Ingresar()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[6];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@rut";
                parParameter[0].SqlDbType = SqlDbType.Char;
                parParameter[0].Size = 10;
                if (cliente.rut == "")
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[0].SqlValue = cliente.rut;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                parParameter[1].SqlValue = cliente.nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@domicilio";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 255;
                if (cliente.domicilio == "")
                {
                    parParameter[2].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[2].SqlValue = cliente.domicilio;
                }

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@id_localidad";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = cliente.id_localidad;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@telefono";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue =cliente.telefono;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@email";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 255;
                parParameter[5].SqlValue = cliente.email;

                con.EjecutarSP("sp_agregarCliente", parParameter);
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

                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_cliente";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = cliente.id_cliente;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@rut";
                parParameter[1].SqlDbType = SqlDbType.Char;
                parParameter[1].Size = 10;
                if (cliente.rut == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = cliente.rut;
                }

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombre";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 60;
                parParameter[2].SqlValue = cliente.nombre;


                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@domicilio";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 60;
                if (cliente.domicilio == "")
                {
                    parParameter[3].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[3].SqlValue = cliente.domicilio;
                }

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@id_localidad";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = cliente.id_localidad;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@telefono";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = cliente.telefono;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@email";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 255;
                parParameter[6].SqlValue = cliente.email;

                con.EjecutarSP("sp_actualizarCliente", parParameter);
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
                parParameter[0].ParameterName = "@id_cliente";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = cliente.id_cliente;

                con.EjecutarSP("sp_eliminarCliente", parParameter);
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
                parParameter[0].ParameterName = "@id_cliente";
                parParameter[0].SqlDbType = SqlDbType.Int;
                if (cliente.id_cliente == 0)
                {
                    parParameter[0].SqlValue = System.Data.SqlTypes.SqlInt32.Null;
                }
                else
                {
                    parParameter[0].SqlValue = cliente.id_cliente;
                }

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@palabraClave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 60;
                if (cliente.palabraClave == "")
                {
                    parParameter[1].SqlValue = System.Data.SqlTypes.SqlString.Null;
                }
                else
                {
                    parParameter[1].SqlValue = cliente.palabraClave;
                }

                dataTable = con.RetornaUno("sp_consultarUnCliente", parParameter);

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
                dataTable = con.RetornaTabla("sp_consultarTODOSCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
