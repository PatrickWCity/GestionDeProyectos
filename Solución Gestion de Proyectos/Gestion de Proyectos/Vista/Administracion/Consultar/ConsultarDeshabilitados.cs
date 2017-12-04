using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarDeshabilitados : Form
    {
        HistoricoAcceso ha = null;
        ControladorHistoricoAcceso cha = null;
        public ConsultarDeshabilitados()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
        }

        private void b_Consultar_Click(object sender, EventArgs e)
        {
            cha = new ControladorHistoricoAcceso(ha);
            DataTable dt = new DataTable();
            dt = cha.ConsultarDeshabilitados();
            dataGridView1.DataSource = dt;
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }
    }
}
