using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarUsuariosDePerfil : Form
    {
        UsuarioPerfil up = null;
        ControladorUsuarioPerfil cup = null;
        Perfil p = null;
        ControladorPerfil cp = null;
        int id_perfil, nroInterno, nroInterno22, swbn;
        public ConsultarUsuariosDePerfil()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";

            swbn = (int)Properties.Settings.Default["UsuarioPerfil"];
            if (swbn == 1)
            {
                l_Perfil.ForeColor = DefaultBackColor;
                l_UsuariosDePerfil.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                l_Perfil.ForeColor = DefaultForeColor;
                l_UsuariosDePerfil.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = MyColor.SkyBlue;
            }
            cp = new ControladorPerfil(p);
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
            l_ZonaMensaje.Text = "";
        }
        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                l_Perfil.ForeColor = DefaultBackColor;
                l_UsuariosDePerfil.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Perfil.ForeColor = DefaultForeColor;
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