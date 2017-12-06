using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormPresupuesto : Form
    {
        Proyecto c = null;
        ControladorProyecto cc = null;
        Presupuesto p = null;
        ControladorPresupuesto cp = null;
        int id_proyecto, monto;
        public FormPresupuesto()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            l_ZonaMensaje.Text = "";

            b_Eliminar.Enabled = false;

            DataTable dt = new DataTable();//presupuesto
            DataTable dt1 = new DataTable();//cliente
            cc = new ControladorProyecto(c);
            dt1 = cc.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Proyecto");

            if (dt1.Rows.Count > 0)
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
            else if (!int.TryParse(tb_Monto.Text, out monto))
            {
                l_ZonaMensaje.Text = "Debe ingresar un monto valido";
            }
            else
            {
                p = new Presupuesto();
                p.id_proyecto = ((KeyValuePair<int, string>)cb_Proyecto.SelectedItem).Key; ;
                p.nombre = tb_Nombre.Text;
                p.monto = int.Parse(tb_Monto.Text);
                cp = new ControladorPresupuesto(p);
                cp.Ingresar();

                l_ZonaMensaje.Text = "Cliente fue ingresado con exito!";
                cb_Proyecto.Text = "Selecionar Presupuesto";



                cp = new ControladorPresupuesto(p);
                DataTable dt2 = new DataTable();
                dt2 = cp.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
                l_ZonaMensaje.Text = "";
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Id_Presupuesto.TextLength == 0)
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
            else if (!int.TryParse(tb_Monto.Text, out monto))
            {
                l_ZonaMensaje.Text = "Debe ingresar un monto valido";
            }
            else
            {
                
                p = new Presupuesto();
                p.id_presupuesto = int.Parse(tb_Id_Presupuesto.Text);
                p.id_proyecto = ((KeyValuePair<int, string>)cb_Proyecto.SelectedItem).Key;
                p.monto = int.Parse(tb_Monto.Text);
                p.nombre = tb_Nombre.Text;
                cp = new ControladorPresupuesto(p);
                cp.Actualizar();
                dataGridView1.Refresh();
                l_ZonaMensaje.Text = "Presupuesto fue actualizado con exito!";

                tb_Id_Presupuesto.Text = string.Empty;
                cb_Proyecto.Text = "Selecionar Proyecto";
                b_Guardar.Enabled = true;
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;


                cp = new ControladorPresupuesto(p);
                DataTable dt2 = new DataTable();
                dt2 = cp.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
                l_ZonaMensaje.Text = "";
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            p = new Presupuesto();
            p.id_presupuesto = int.Parse(tb_Id_Presupuesto.Text);
            cp = new ControladorPresupuesto(p);
            cp.Eliminar();
            l_ZonaMensaje.Text = "Presupuesto fue eliminado con exito!";
            tb_Id_Presupuesto.Text = string.Empty;
            cb_Proyecto.Text = string.Empty;
            tb_Id_Presupuesto.Enabled = true;
            tb_Id_Presupuesto.Focus();
            dataGridView1.Refresh();
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            b_Guardar.Enabled = true;

            cp = new ControladorPresupuesto(p);
            DataTable dt2 = new DataTable();
            dt2 = cp.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Consultar_Click(object sender, EventArgs e)//LISTO
        {
            cp = new ControladorPresupuesto(p);
            DataTable dt2 = new DataTable();
            dt2 = cp.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_Id_Presupuesto.Text = string.Empty;
            cb_Proyecto.Text = "Selecione Proyecto";
            tb_Id_Presupuesto.Focus();
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
                tb_Id_Presupuesto.Text = dataGridView1.Rows[e.RowIndex].Cells["id_presupuesto"].Value.ToString();
                cb_Proyecto.SelectedIndex = (int)dataGridView1.Rows[e.RowIndex].Cells["id_proyecto"].Value;
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
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