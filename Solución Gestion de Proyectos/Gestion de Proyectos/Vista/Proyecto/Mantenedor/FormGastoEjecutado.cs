using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormGastoEjecutado : Form
    {
        Item c = null;
        ControladorItem cc = null;
        GastoEjecutado p = null;
        ControladorGastoEjecutado cp = null;
        int id_proyecto;
        int monto;
        public FormGastoEjecutado()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;

            l_ZonaMensaje.Text = "";

            DataTable dt = new DataTable();//presupuesto
            DataTable dt1 = new DataTable();//cliente
            cc = new ControladorItem(c);
            dt1 = cc.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Item");

            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow row in dt1.Rows)
                {
                    test.Add((int)row[0], row[1].ToString());
                }
                cb_Item.DataSource = new BindingSource(test, null);
                cb_Item.DisplayMember = "Value";
                cb_Item.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }
        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_Monto.Text, out monto))
            {
                l_ZonaMensaje.Text = "Debe ingresar un Monto valido";
            }
            else
            {
                p = new GastoEjecutado();
                p.id_item = ((KeyValuePair<int, string>)cb_Item.SelectedItem).Key;
                p.monto = int.Parse(tb_Monto.Text);
                cp = new ControladorGastoEjecutado(p);
                cp.Ingresar();

                l_ZonaMensaje.Text = "Cliente fue ingresado con exito!";
                cb_Item.Text = "Selecionar Item";



                cp = new ControladorGastoEjecutado(p);
                DataTable dt2 = new DataTable();
                dt2 = cp.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Id_GastoEjecutado.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el ID del Item a Actualizar";

            }
            else
            {
                if (!int.TryParse(tb_Monto.Text, out monto))
                {
                    l_ZonaMensaje.Text = "Debe ingresar un Monto valido";
                }
                else
                {
                    p = new GastoEjecutado();
                    p.id_gastoEjecutado = int.Parse(tb_Id_GastoEjecutado.Text);
                    p.id_item = ((KeyValuePair<int, string>)cb_Item.SelectedItem).Key;
                    p.monto = int.Parse(tb_Monto.Text);
                    cp = new ControladorGastoEjecutado(p);
                    cp.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text = "GastoEjecutado fue actualizado con exito!";

                    tb_Id_GastoEjecutado.Text = string.Empty;
                    cb_Item.Text = "Selecionar Item";
                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;


                    cp = new ControladorGastoEjecutado(p);
                    DataTable dt2 = new DataTable();
                    dt2 = cp.ConsultarPorTodos();
                    dataGridView1.DataSource = dt2;
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            p = new GastoEjecutado();
            p.id_gastoEjecutado = int.Parse(tb_Id_GastoEjecutado.Text);
            cp = new ControladorGastoEjecutado(p);
            cp.Eliminar();
            l_ZonaMensaje.Text = "GastoEjecutado fue eliminado con exito!";
            tb_Id_GastoEjecutado.Text = string.Empty;
            tb_Monto.Text = string.Empty;
            cb_Item.Text = string.Empty;
            tb_Id_GastoEjecutado.Enabled = true;
            tb_Id_GastoEjecutado.Focus();
            dataGridView1.Refresh();
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            b_Guardar.Enabled = true;

            cp = new ControladorGastoEjecutado(p);
            DataTable dt2 = new DataTable();
            dt2 = cp.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Consultar_Click(object sender, EventArgs e)//LISTO
        {
            cp = new ControladorGastoEjecutado(p);
            DataTable dt2 = new DataTable();
            dt2 = cp.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_Id_GastoEjecutado.Text = string.Empty;
            tb_Monto.Text = string.Empty;
            cb_Item.Text = "Selecione Item";
            tb_Id_GastoEjecutado.Focus();
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
                tb_Id_GastoEjecutado.Text = dataGridView1.Rows[e.RowIndex].Cells["id_gastoEjecutado"].Value.ToString();
                cb_Item.SelectedItem = (int)dataGridView1.Rows[e.RowIndex].Cells["id_item"].Value;
                tb_Monto.Text = dataGridView1.Rows[e.RowIndex].Cells["monto"].Value.ToString();//ver
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
