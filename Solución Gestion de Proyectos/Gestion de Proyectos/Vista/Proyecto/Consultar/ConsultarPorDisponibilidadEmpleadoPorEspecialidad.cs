using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarPorDisponibilidadEmpleadoPorEspecialidad : Form
    {
        EspecialidadEmpleado up = null;
        ControladorEspecialidadEmpleado cup = null;
        Especialidad p = null;//perfil
        ControladorEspecialidad cp = null;//conp
        int id_especialidad, nroInterno, nroInterno2, swbn;

        public ConsultarPorDisponibilidadEmpleadoPorEspecialidad()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";

            swbn = (int)Properties.Settings.Default["EspecialidadEmpleado"];
            if (swbn == 1)
            {
                l_Perfil.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                l_Perfil.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = MyColor.SkyBlue;
            }
            cp = new ControladorEspecialidad(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Especialidad");

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
            up = new EspecialidadEmpleado();
            id_especialidad = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_especialidad = id_especialidad;
            cup = new ControladorEspecialidadEmpleado(up);

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarDisponibilidadEmpleadoPorEspecialidad();
            dataGridView1.DataSource = dt1;
            l_ZonaMensaje.Text = "";
        }
        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                l_Perfil.ForeColor = DefaultBackColor;
                l_Usuarios.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Perfil.ForeColor = DefaultForeColor;
                l_Usuarios.ForeColor = Color.Green;
                l_ZonaMensaje.ForeColor = Color.Red;
                BackColor = MyColor.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["EspecialidadEmpleado"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}