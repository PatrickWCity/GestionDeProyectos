using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarPorProyectoPorFinalizar3SemanasAntes : Form
    {
        Proyecto c = null;
        ControladorProyecto cc = null;
        public ConsultarPorProyectoPorFinalizar3SemanasAntes()
        {
            InitializeComponent();
            cc = new ControladorProyecto(c);
            DataTable dt2 = new DataTable();
            dt2 = cc.ConsultarProyectoPorFinalizar3Semanas();
            dataGridView1.DataSource = dt2;
        }

        private void b_Consultar_Click(object sender, EventArgs e)
        {
            cc = new ControladorProyecto(c);
            DataTable dt2 = new DataTable();
            dt2 = cc.ConsultarProyectoPorFinalizar3Semanas();
            dataGridView1.DataSource = dt2;
        }
    }
}
