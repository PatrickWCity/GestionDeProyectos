using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormEmpleadoProyecto : Form
    {
        EmpleadoProyecto c = null;//empleadoproyecto
        ControladorEmpleadoProyecto cc = null;//empleadoproyecto
        Proyecto p = null;//rpoyecto
        ControladorProyecto cp = null;
        Usuario cl = null;//usuario
        ControladorUsuario ccl = null;
        Cargo ca = null;
        ControladorCargo cca = null;
        public FormEmpleadoProyecto()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;

            DataTable dt = new DataTable();//usuario
            DataTable dt1 = new DataTable();//proyecto
            DataTable dt3 = new DataTable();
            cp = new ControladorProyecto(p);
            dt1 = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Proyecto");

            if (dt1.Rows.Count > 0)//proyecto
            {
                foreach (DataRow row in dt1.Rows)
                {
                    test.Add((int)row[0], row[1].ToString());
                }
                cb_Proyecto.DataSource = new BindingSource(test, null);
                cb_Proyecto.DisplayMember = "Value";
                cb_Proyecto.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }



            ccl = new ControladorUsuario(cl);
            dt = ccl.ConsultarPorTodos();

            Dictionary<int, string> test1 = new Dictionary<int, string>();
            test1.Add(0, "Selecionar Empleado");

            if (dt.Rows.Count > 0)//usuario
            {
                foreach (DataRow row in dt.Rows)
                {
                    test1.Add((int)row[0], row[2].ToString()+" "+ row[3].ToString() + " " +row[4].ToString());
                }
                cb_Empleado.DataSource = new BindingSource(test1, null);
                cb_Empleado.DisplayMember = "Value";
                cb_Empleado.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }



            cca = new ControladorCargo(ca);
            dt = cca.ConsultarPorTodos();

            Dictionary<int, string> test2 = new Dictionary<int, string>();
            test2.Add(0, "Selecionar Cargo");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test2.Add((int)row[0], row[1].ToString());
                }
               cb_Cargo.DataSource = new BindingSource(test2, null);
                cb_Cargo.DisplayMember = "Value";
                cb_Cargo.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }


        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            c = new EmpleadoProyecto();
            c.id_proyecto = ((KeyValuePair<int, string>)cb_Proyecto.SelectedItem).Key;
            c.nroInterno = ((KeyValuePair<int, string>)cb_Empleado.SelectedItem).Key;
            c.nroInterno = ((KeyValuePair<int, string>)cb_Empleado.SelectedItem).Key;
            cc = new ControladorEmpleadoProyecto(c);
            cc.Ingresar();

            l_ZonaMensaje.Text = "Cliente fue ingresado con exito!";
            cb_Proyecto.Text = "Selecionar Proyecto";
            cb_Empleado.Text = "Selecionar Empleado";
            cb_Cargo.Text = "Selecionar Cargo";


            cc = new ControladorEmpleadoProyecto(c);
            DataTable dt2 = new DataTable();
            dt2 = cc.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;


        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Id_Proyecto.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el ID del Proyecto a Actualizar";

            }
            else
            {

                c = new EmpleadoProyecto();
                c.id_proyecto = int.Parse(tb_Id_Proyecto.Text);
                c.id_proyecto = ((KeyValuePair<int, string>)cb_Proyecto.SelectedItem).Key;
                c.nroInterno = ((KeyValuePair<int, string>)cb_Empleado.SelectedItem).Key;
                c.nroInterno = ((KeyValuePair<int, string>)cb_Empleado.SelectedItem).Key;
                cc = new ControladorEmpleadoProyecto(c);
                cc.Actualizar();
                dataGridView1.Refresh();
                l_ZonaMensaje.Text = "Cliente fue actualizado con exito!";

                tb_Id_Proyecto.Text = string.Empty;
                cb_Proyecto.Text = "Selecionar Proyecto";
                cb_Empleado.Text = "Selecionar Empleado";
                cb_Cargo.Text = "Selecionar Cargo";
                b_Guardar.Enabled = true;
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;


                cc = new ControladorEmpleadoProyecto(c);
                DataTable dt2 = new DataTable();
                dt2 = cc.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            c = new EmpleadoProyecto();
            c.id_ep = int.Parse(tb_Id_Proyecto.Text);
            cc = new ControladorEmpleadoProyecto(c);
            cc.Eliminar();
            l_ZonaMensaje.Text = "Cliente fue eliminado con exito!";
            tb_Id_Proyecto.Text = string.Empty;
            cb_Proyecto.Text = string.Empty;
            cb_Empleado.Text = string.Empty;
            cb_Cargo.Text = string.Empty;
            tb_Id_Proyecto.Enabled = true;
            tb_Id_Proyecto.Focus();
            dataGridView1.Refresh();
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            b_Guardar.Enabled = true;


            cc = new ControladorEmpleadoProyecto(c);
            DataTable dt2 = new DataTable();
            dt2 = cc.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Consultar_Click(object sender, EventArgs e)//LISTO
        {
            cc = new ControladorEmpleadoProyecto(c);
            DataTable dt2 = new DataTable();
            dt2 = cc.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_Id_Proyecto.Text = string.Empty;
            cb_Proyecto.Text = "Selecione Cliente";
            cb_Empleado.Text = "Selecione Presupuesto";
            tb_Id_Proyecto.Focus();
            b_Guardar.Enabled = true;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
        }//listo ....
        private void b_Salir_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tb_Id_Proyecto.Text = dataGridView1.Rows[e.RowIndex].Cells["id_ep"].Value.ToString();
                cb_Empleado.SelectedIndex = (int)dataGridView1.Rows[e.RowIndex].Cells["nroInterno"].Value;//ver
                cb_Proyecto.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["id_proyecto"].Value.ToString();// ver
                cb_Cargo.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells["id_cargo"].Value.ToString();// ver
                b_Guardar.Enabled = false;
                b_Eliminar.Enabled = true;
                b_Actualizar.Enabled = true;
            }
            else
            {

            }
        }
    }
}