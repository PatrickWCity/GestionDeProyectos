using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class AsignarEspecialidadEmpleado : Form
    {
        EspecialidadEmpleado up = null;
        ControladorEspecialidadEmpleado cup = null;
        Especialidad p = null;//perfil
        ControladorEspecialidad cp = null;//conp
        int id_especialidad, nroInterno, swbn;
        public AsignarEspecialidadEmpleado()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;

            swbn = (int)Properties.Settings.Default["EspecialidadEmpleado"];
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
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorEspecialidadesDeEmpleado();
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorEspecialidadesSinEmpleado();
            dataGridView1.DataSource = dt1;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                nroInterno = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["nroInterno"].Value.ToString());
            }
            else
            {
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                nroInterno = int.Parse(dataGridView2.Rows[e.RowIndex].Cells["nroInterno"].Value.ToString());
            }
            else
            {
            }
        }
        private void b_Asignar_Click(object sender, EventArgs e)
        {
            up = new EspecialidadEmpleado();
            up.nroInterno = nroInterno;
            up.id_especialidad = id_especialidad;
            cup = new ControladorEspecialidadEmpleado(up);
            cup.AsignarEspecialidadAEmpleado();

            id_especialidad = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_especialidad = id_especialidad;
            cup = new ControladorEspecialidadEmpleado(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorEspecialidadesDeEmpleado();
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorEspecialidadesSinEmpleado();
            dataGridView1.DataSource = dt1;
        }
        private void b_Desasignar_Click(object sender, EventArgs e)
        {
            up = new EspecialidadEmpleado();
            up.nroInterno = nroInterno;
            up.id_especialidad = id_especialidad;
            cup = new ControladorEspecialidadEmpleado(up);
            cup.DesasignarEspecialidadDeEmpleado();

            id_especialidad = ((KeyValuePair<int, string>)cb_Perfil.SelectedItem).Key;
            up.id_especialidad = id_especialidad;
            cup = new ControladorEspecialidadEmpleado(up);
            DataTable dt = new DataTable();
            dt = cup.ConsultarPorEspecialidadesDeEmpleado();
            dataGridView2.DataSource = dt;

            //cu = new ControladorUsuario(u);
            DataTable dt1 = new DataTable();
            dt1 = cup.ConsultarPorEspecialidadesSinEmpleado();
            dataGridView1.DataSource = dt1;
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
            Properties.Settings.Default["EspecialidadEmpleado"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}
