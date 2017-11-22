using System;
using System.Data;
using System.Data.SqlClient;
using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorHistoricoPassword
    {
        Connection con = null;
        Acceso a = null;
        HistoricoPassword hp = null;
        DataTable dataTable = null;
        public ControladorHistoricoPassword(Acceso parAcceso, HistoricoPassword parHp)
        {
            a = parAcceso;
            hp = parHp;
        }
        public DataTable VerificarClaveUsuario()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@username";
                parParameter[0].SqlDbType = SqlDbType.VarChar;
                parParameter[0].Size = 20;
                parParameter[0].SqlValue = a.username;


                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@clave";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 20;
                parParameter[1].SqlValue = hp.clave;

                dataTable = con.RetornaUno("sp_verificarClaveUsuario", parParameter);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }

}
