using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Gestion_de_Proyectos.Controlador
{
    class ControladorItemPresupuesto
    {
        Connection con = null;
        ItemPresupuesto itemPresupuesto = null;
        DataTable dataTable = null;
        public ControladorItemPresupuesto(ItemPresupuesto parItemPresupuesto)
        {
            itemPresupuesto = parItemPresupuesto;
        }
        public void AsignarUsuarioAPerfil()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_item";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = itemPresupuesto.id_item;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_presupuesto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = itemPresupuesto.id_presupuesto;

                con.EjecutarSP("sp_asignarItemAPresupuesto", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DesasignarUsuarioDePerfil()
        {
            try
            {
                con = new Connection();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_item";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = itemPresupuesto.id_item;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@id_presupuesto";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = itemPresupuesto.id_presupuesto;

                con.EjecutarSP("sp_desasignarItemDePresupuesto", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ConsultarPorUsuariosDePerfil()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_presupuesto";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = itemPresupuesto.id_presupuesto;

                dataTable = con.RetornaUno("sp_consultarItemsDePresupuesto", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
        public DataTable ConsultarPorUsuariosSinPerfil()
        {
            dataTable = new DataTable();
            try
            {
                con = new Connection();
                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@id_presupuesto";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = itemPresupuesto.id_presupuesto;

                dataTable = con.RetornaUno("sp_consultarItemsSinPresupuesto", parParameter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dataTable;
        }
    }
}
