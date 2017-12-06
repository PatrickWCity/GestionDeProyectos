using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Drawing;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarHabilitados : Form
    {
        HistoricoAcceso ha = null;
        ControladorHistoricoAcceso cha = null;
        int swbn;
        public ConsultarHabilitados()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            swbn = (int)Properties.Settings.Default["CH"];
            if (swbn == 1)
            {
                BackColor = DefaultForeColor;
            }
            else
            {
                BackColor = Color.Orange;
            }
        }

        private void b_Consultar_Click(object sender, EventArgs e)
        {
            cha = new ControladorHistoricoAcceso(ha);
            DataTable dt = new DataTable();
            dt = cha.ConsultarHabilitados();
            dataGridView1.DataSource = dt;
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }

        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                BackColor = Color.Orange;
                swbn = 0;
            }
            Properties.Settings.Default["CH"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}
