using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarItemDePresupuesto : Form
    {
        ItemPresupuesto up = null;
        ControladorItemPresupuesto cup = null;
        Presupuesto p = null;
        ControladorPresupuesto cp = null;
        int id_presupuesto, id_item, id_item2, swbn;
        public ConsultarItemDePresupuesto()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";

            swbn = (int)Properties.Settings.Default["ItemPresupuesto"];
            if (swbn == 1)
            {
                l_Presupuesto.ForeColor = DefaultBackColor;
                l_UsuariosDePresupuesto.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                l_Presupuesto.ForeColor = DefaultForeColor;
                l_UsuariosDePresupuesto.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = MyColor.SkyBlue;
            }
            cp = new ControladorPresupuesto(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test.Add((int)row[0], row[1].ToString());
                }
                cb_Presupuesto.DataSource = new BindingSource(test, null);
                cb_Presupuesto.DisplayMember = "Value";
                cb_Presupuesto.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Presupuestoes Disponible";
            }
        }
        private void cb_Presupuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            up = new ItemPresupuesto();
            id_presupuesto = ((KeyValuePair<int, string>)cb_Presupuesto.SelectedItem).Key;
            up.id_presupuesto = id_presupuesto;
            cup = new ControladorItemPresupuesto(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorUsuariosDePerfil();
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorUsuariosSinPerfil();
            //verdataGridView1.AutoGenerateColumns = false;
            l_ZonaMensaje.Text = "";
        }
        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                l_Presupuesto.ForeColor = DefaultBackColor;
                l_UsuariosDePresupuesto.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Presupuesto.ForeColor = DefaultForeColor;
                l_UsuariosDePresupuesto.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = Color.Red;
                BackColor = MyColor.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["ItemPresupuesto"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}
