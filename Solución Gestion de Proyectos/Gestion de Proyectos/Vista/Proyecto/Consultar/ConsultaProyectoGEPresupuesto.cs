using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultaProyectoGEPresupuesto : Form
    {
        Proyecto p = null;
        ControladorProyecto cp = null;
        int id_presupuesto, swbn;
        public ConsultaProyectoGEPresupuesto()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";
            swbn = (int)Properties.Settings.Default["Proyecto"];
            if (swbn == 1)
            {
                l_Presupuesto.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                l_Presupuesto.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Black;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = MyColor.SkyBlue;
            }
        }
        private void cb_Presupuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //p = new Proyecto();
            if (cb_Presupuesto.SelectedIndex == 1)
            {
                id_presupuesto = cb_Presupuesto.SelectedIndex;
                cp = new ControladorProyecto(p);
                DataTable dt = new DataTable();
                dt = cp.ConsultarProyectosConGEbajoPresupuesto();
                dataGridView1.DataSource = dt;
                l_ZonaMensaje.Text = "";
            }
            else if (cb_Presupuesto.SelectedIndex == 2)
            {
                id_presupuesto = cb_Presupuesto.SelectedIndex;
                cp = new ControladorProyecto(p);
                DataTable dt = new DataTable();
                dt = cp.ConsultarProyectosConGEsobrePresupuesto();
                dataGridView1.DataSource = dt;
                l_ZonaMensaje.Text = "";
            }
            else if(cb_Presupuesto.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
        }
        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                l_Presupuesto.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Presupuesto.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Black;
                l_ZonaMensaje.ForeColor = Color.Red;
                BackColor = MyColor.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["Proyecto"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}