using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class AsignarSubmoduloModulo : Form
    {
        SubmoduloModulo up = null;
        ControladorSubmoduloModulo cup = null;
        Modulo p = null;
        ControladorModulo cp = null;
        int id_perfil, nroInterno, nroInterno2, swbn;
        public AsignarSubmoduloModulo()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";

            swbn = (int)Properties.Settings.Default["SubmoduloModulo"];
            if (swbn == 1)
            {
                l_Perfil.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_UsuariosDePerfil.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                l_Perfil.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Red;
                l_UsuariosDePerfil.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = MyColor.SkyBlue;
            }
            cp = new ControladorModulo(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Modulo");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test.Add((int)row[0], row[1].ToString());
                }
                cb_Perfil.DataSource = new BindingSource(test, null);
                cb_Perfil.DisplayMember = "Value";
                cb_Perfil.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Moduloes Disponible";
            }
        }
        private void cb_Modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            up = new SubmoduloModulo();
            id_perfil = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_modulo = id_perfil;
            cup = new ControladorSubmoduloModulo(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorSubmodulosDeModulo();
            dataGridView2.DataSource = dt;

            //cu = new ControladorSubmodulo(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorSubmodulosSinModulo();
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
            l_ZonaMensaje.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                nroInterno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["id_submodulo"].Value.ToString());
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
                nroInterno2 = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["id_submodulo"].Value.ToString());
                dataGridView1.ClearSelection();
            }
            else
            {
            }
        }
        private void b_Asignar_Click(object sender, EventArgs e)
        {
            if (((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key ==0)
            {

                l_ZonaMensaje.Text = "Debe selecionar un Modulo primero";
            }
            else if (nroInterno != 0)
            {
                up = new SubmoduloModulo();
            up.id_submodulo = nroInterno;
            up.id_modulo = id_perfil;
            cup = new ControladorSubmoduloModulo(up);
            cup.AsignarSubmoduloAModulo();

            id_perfil = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_modulo = id_perfil;
            cup = new ControladorSubmoduloModulo(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorSubmodulosDeModulo();
            //dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;

            //cu = new ControladorSubmodulo(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorSubmodulosSinModulo();
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
                nroInterno = 0;
                dataGridView1.ClearSelection();
                l_ZonaMensaje.Text = "";
            }
            else
                l_ZonaMensaje.Text = "Debe Seleccionar un Submodulo sin el Modulo";
        }
        private void b_Desasignar_Click(object sender, EventArgs e)
        {
            if (((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key == 0)
            {

                l_ZonaMensaje.Text = "Debe selecionar un Modulo primero";
            }
            else if (nroInterno2 != 0)
            {
                up = new SubmoduloModulo();
            up.id_submodulo = nroInterno2;
            up.id_modulo = id_perfil;
            cup = new ControladorSubmoduloModulo(up);
            cup.DesasignarSubmoduloDeModulo();

            id_perfil = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_modulo = id_perfil;
            cup = new ControladorSubmoduloModulo(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorSubmodulosDeModulo();
            //dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;

            //cu = new ControladorSubmodulo(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorSubmodulosSinModulo();
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
                dataGridView2.ClearSelection();
                nroInterno2 = 0;
                l_ZonaMensaje.Text = "";
            }
            else
                l_ZonaMensaje.Text = "Debe Seleccionar un Submodulo con el Modulo";
        }
        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                l_Perfil.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_UsuariosDePerfil.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Perfil.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Red;
                l_UsuariosDePerfil.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = Color.Red;
                BackColor = MyColor.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["SubmoduloModulo"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}