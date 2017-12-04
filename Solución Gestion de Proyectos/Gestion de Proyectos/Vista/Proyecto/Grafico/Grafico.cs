using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class Grafico : Form
    {
        Modelo.Proyecto p = null;
        ControladorProyecto cp = null;
        int id_proyecto;
        public Grafico()
        {
            InitializeComponent();


            cp = new ControladorProyecto(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Proyecto");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test.Add((int)row[0], row[1].ToString());
                }
                cb_Proyecto.DataSource = new BindingSource(test, null);
                cb_Proyecto.DisplayMember = "Value";
                cb_Proyecto.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }



        }

        private void cb_Proyecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_proyecto = ((KeyValuePair<int, string>)cb_Proyecto.SelectedItem).Key;


            p = new Modelo.Proyecto();
            p.id_proyecto = id_proyecto;
            cp = new ControladorProyecto(p);
            cp.ConsultarGraficoGEGPProyecto();


            
            chart.DataSource = cp.ConsultarGraficoGEGPProyecto();
            chart.Series["Gasto Presupuesto"].XValueMember = "fechaInicio";
            chart.Series["Gasto Presupuesto"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series["Gasto Presupuesto"].YValueMembers = "Presupuesto";
            chart.Series["Gasto Presupuesto"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;

            chart.DataSource = cp.ConsultarGraficoGEGPProyecto();
            chart.Series["Gasto Ejecutado"].XValueMember = "fechaTermino";
            chart.Series["Gasto Ejecutado"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart.Series["Gasto Ejecutado"].YValueMembers = "GastoEjecutado";
            chart.Series["Gasto Ejecutado"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;


        }
    }
}
