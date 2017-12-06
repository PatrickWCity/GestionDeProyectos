using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormProyecto : Form
    {
        Proyecto c = null;
        ControladorProyecto cc = null;
        Presupuesto p = null;
        ControladorPresupuesto cp = null;
        Cliente cl = null;
        ControladorCliente ccl = null;
        public FormProyecto()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;

            l_ZonaMensaje.Text = "";


            DataTable dt = new DataTable();//presupuesto
            DataTable dt1 = new DataTable();//cliente
           cp = new ControladorPresupuesto(p);
            dt1 = cp.ConsultarPorTodos();
           

            ccl = new ControladorCliente(cl);
            dt = ccl.ConsultarPorTodos();

            Dictionary<int, string> test1 = new Dictionary<int, string>();
            test1.Add(0, "Selecionar Cliente");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test1.Add((int)row[0], row[2].ToString());
                }
                cb_Cliente.DataSource = new BindingSource(test1, null);
                cb_Cliente.DisplayMember = "Value";
                cb_Cliente.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }




        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar un Nombre";
            }
            else if (tb_Nombre.TextLength >= 60)
            {
                l_ZonaMensaje.Text = "Debe ingresar un Nombre con 60 caracteres o menos";
            }
            else if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                l_ZonaMensaje.Text = "La Fecha de Inicio no puede ser Despues de la Fecha de Termino";
            }
            else
            {
                c = new Proyecto();
                c.nombre = tb_Nombre.Text;
                c.id_cliente = ((KeyValuePair<int, string>)cb_Cliente.SelectedItem).Key;
                c.fechaInicio = dateTimePicker1.Value;//ver
                c.fechaTermino = dateTimePicker2.Value;//ver
                cc = new ControladorProyecto(c);
                cc.Ingresar();

                l_ZonaMensaje.Text = "Cliente fue ingresado con exito!";
                cb_Cliente.Text = "Selecionar Cliente";



                cc = new ControladorProyecto(c);
                DataTable dt2 = new DataTable();
                dt2 = cc.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Id_Proyecto.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el ID del Proyecto a Actualizar";

            }
            else if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar un Nombre";
            }
            else if (tb_Nombre.TextLength >= 60)
            {
                l_ZonaMensaje.Text = "Debe ingresar un Nombre con 60 caracteres o menos";
            }
            else
            {
                
                c = new Proyecto();
                c.id_proyecto = int.Parse(tb_Id_Proyecto.Text);
                c.nombre = tb_Nombre.Text;
                c.id_cliente = ((KeyValuePair<int, string>)cb_Cliente.SelectedItem).Key;
                c.fechaInicio = dateTimePicker1.Value;//ver
                c.fechaTermino = dateTimePicker2.Value;//ver
                cc = new ControladorProyecto(c);
                cc.Actualizar();
                dataGridView1.Refresh();
                l_ZonaMensaje.Text = "Cliente fue actualizado con exito!";

                tb_Id_Proyecto.Text = string.Empty;
                cb_Cliente.Text = "Selecionar Cliente";
                b_Guardar.Enabled = true;
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;


                cc = new ControladorProyecto(c);
                DataTable dt2 = new DataTable();
                dt2 = cc.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            c = new Proyecto();
            c.id_cliente = int.Parse(tb_Id_Proyecto.Text);
            cc = new ControladorProyecto(c);
            cc.Eliminar();
            l_ZonaMensaje.Text = "Cliente fue eliminado con exito!";
            tb_Id_Proyecto.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            cb_Cliente.Text = string.Empty;
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            tb_Id_Proyecto.Enabled = true;
            tb_Id_Proyecto.Focus();
            dataGridView1.Refresh();
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            b_Guardar.Enabled = true;


            cc = new ControladorProyecto(c);
            DataTable dt2 = new DataTable();
            dt2 = cc.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Consultar_Click(object sender, EventArgs e)//LISTO
        {
                cc = new ControladorProyecto(c);
                DataTable dt2 = new DataTable();
                dt2 = cc.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_Id_Proyecto.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            cb_Cliente.Text = "Selecione Cliente";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
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
                tb_Id_Proyecto.Text = dataGridView1.Rows[e.RowIndex].Cells["id_proyecto"].Value.ToString();
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                cb_Cliente.Text = dataGridView1.Rows[e.RowIndex].Cells["cliente"].Value.ToString();// ver
                dateTimePicker1.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["fechaInicio"].Value;
                dateTimePicker2.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["fechaTermino"].Value;
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