using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Collections.Generic;
using System.Drawing;

namespace Gestion_de_Proyectos.Vista
{
    public partial class AsignarUsuarioPerfil : Form
    {
        UsuarioPerfil up = null;
        ControladorUsuarioPerfil cup = null;
        Perfil p = null;
        ControladorPerfil cp = null;
        int id_perfil, nroInterno, nroInterno22, swbn;
        public AsignarUsuarioPerfil()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";

            swbn = (int)Properties.Settings.Default["UsuarioPerfil"];
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
            cp = new ControladorPerfil(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Perfil");

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
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }
        }
        private void cb_Perfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            up = new UsuarioPerfil();
            id_perfil = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_perfil = id_perfil;
            cup = new ControladorUsuarioPerfil(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorUsuariosDePerfil();
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorUsuariosSinPerfil();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
            l_ZonaMensaje.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                nroInterno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["nroInterno1"].Value.ToString());
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
                nroInterno22 = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["nroInterno2"].Value.ToString());
                dataGridView1.ClearSelection();
            }
            else
            {
            }
        }
        private void b_Asignar_Click(object sender, EventArgs e)
        {
            if (((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key == 0)
            {

                l_ZonaMensaje.Text = "Debe selecionar un Perfil primero";
            }
            else if (nroInterno != 0)
            {
                up = new UsuarioPerfil();
                up.nroInterno = nroInterno;
                up.id_perfil = id_perfil;
                cup = new ControladorUsuarioPerfil(up);
                cup.AsignarUsuarioAPerfil();

                id_perfil = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
                up.id_perfil = id_perfil;
                cup = new ControladorUsuarioPerfil(up);
                DataTable dt = new DataTable();
                dt = cup.ConsultarPorUsuariosDePerfil();
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = dt;

                //cu = new ControladorUsuario(u);
                DataTable dt1 = new DataTable();
                dt1 = cup.ConsultarPorUsuariosSinPerfil();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt1;
                dataGridView1.ClearSelection();
                nroInterno = 0;
                l_ZonaMensaje.Text = "";
            }
            else
                l_ZonaMensaje.Text = "Debe Seleccionar un Usuario sin el Perfil";
            }
        private void b_Desasignar_Click(object sender, EventArgs e)
        {
            if (((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key == 0)
            {

                l_ZonaMensaje.Text = "Debe selecionar un Perfil primero";
            }
            else if (nroInterno22 != 0)
            {
                up = new UsuarioPerfil();
            up.nroInterno = nroInterno22;
            up.id_perfil = id_perfil;
            cup = new ControladorUsuarioPerfil(up);
            cup.DesasignarUsuarioDePerfil();

            id_perfil = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_perfil = id_perfil;
            cup = new ControladorUsuarioPerfil(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorUsuariosDePerfil();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorUsuariosSinPerfil();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt1;
                dataGridView2.ClearSelection();
                nroInterno22 = 0;
                l_ZonaMensaje.Text = "";
            }
            else
                l_ZonaMensaje.Text = "Debe Seleccionar un Usuario con el Perfil";
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
            Properties.Settings.Default["UsuarioPerfil"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}