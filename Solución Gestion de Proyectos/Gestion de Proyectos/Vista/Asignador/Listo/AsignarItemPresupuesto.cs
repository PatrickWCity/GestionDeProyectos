using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class AsignarItemPresupuesto : Form
    {
        ItemPresupuesto up = null;
        ControladorItemPresupuesto cup = null;
        Presupuesto p = null;
        ControladorPresupuesto cp = null;
        int id_presupuesto, id_item, id_item2 , swbn;
        public AsignarItemPresupuesto()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";

            swbn = (int)Properties.Settings.Default["ItemPresupuesto"];
            if (swbn == 1)
            {
                l_Presupuesto.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_UsuariosDePresupuesto.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                l_Presupuesto.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Red;
                l_UsuariosDePresupuesto.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = MyColor.SkyBlue;
            }
            cp = new ControladorPresupuesto(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Presupuesto");

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
            dataGridView1.DataSource = dt1;
            l_ZonaMensaje.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_item = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id_item"].Value.ToString());
                dataGridView2.ClearSelection();
            }
            else
            {
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id_item2 = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["id_item"].Value.ToString());
                dataGridView1.ClearSelection();
            }
            else
            {
            }
        }
        private void b_Asignar_Click(object sender, EventArgs e)
        {
            if (((KeyValuePair<int, string>)cb_Presupuesto.SelectedItem).Key == 0)
            {

                l_ZonaMensaje.Text = "Debe selecionar un Presupuesto primero";
            }
            else if (id_item != 0)
            {
                up = new ItemPresupuesto();
            up.id_item = id_item;
            up.id_presupuesto = id_presupuesto;
            cup = new ControladorItemPresupuesto(up);
            cup.AsignarUsuarioAPerfil();

            id_presupuesto = ((KeyValuePair<int, string>)cb_Presupuesto.SelectedItem).Key;
            up.id_presupuesto = id_presupuesto;
            cup = new ControladorItemPresupuesto(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorUsuariosDePerfil();
            ///verdataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorUsuariosSinPerfil();
            ///verdataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
                dataGridView1.ClearSelection();
                id_item = 0;
                l_ZonaMensaje.Text = "";
            }
            else
                l_ZonaMensaje.Text = "Debe Seleccionar un Item sin el Presupuesto";
        }
        private void b_Desasignar_Click(object sender, EventArgs e)
        {
            if (((KeyValuePair<int, string>)cb_Presupuesto.SelectedItem).Key == 0)
            {

                l_ZonaMensaje.Text = "Debe selecionar un Presupuesto primero";
            }
            else if (id_item2 != 0)
            {
                up = new ItemPresupuesto();
            up.id_item = id_item2;
            up.id_presupuesto = id_presupuesto;
            cup = new ControladorItemPresupuesto(up);
            cup.DesasignarUsuarioDePerfil();

            id_presupuesto = ((KeyValuePair<int, string>)cb_Presupuesto.SelectedItem).Key;
            up.id_presupuesto = id_presupuesto;
            cup = new ControladorItemPresupuesto(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorUsuariosDePerfil();
            //verdataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorUsuariosSinPerfil();
            ///verdataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
                dataGridView2.ClearSelection();
                id_item2 = 0;
                l_ZonaMensaje.Text = "";
            }
            else
                l_ZonaMensaje.Text = "Debe Seleccionar un Item con el Presupuesto";
        }
        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                l_Presupuesto.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_UsuariosDePresupuesto.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Presupuesto.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Red;
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