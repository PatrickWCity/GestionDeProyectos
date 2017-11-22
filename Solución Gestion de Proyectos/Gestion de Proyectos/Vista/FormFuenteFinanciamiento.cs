using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormFuenteFinanciamiento : Form
    {
        TipoFuenteFinanciamiento c = null;
        ControladorTipoFuenteFinanciamiento cc = null;
        FuenteFinanciamiento p = null;
        ControladorFuenteFinanciamiento cp = null;
        int id_fuenteFinanciamiento;
        public FormFuenteFinanciamiento()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;

            DataTable dt = new DataTable();//presupuesto
            DataTable dt1 = new DataTable();//cliente
            cc = new ControladorTipoFuenteFinanciamiento(c);
            dt1 = cc.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Tipo Fuente Financiamiento");

            if (dt1.Rows.Count > 0)
            {
                foreach (DataRow row in dt1.Rows)
                {
                    test.Add((int)row[0], row[1].ToString());
                }
                cb_TipoFuenteFinanciamiento.DataSource = new BindingSource(test, null);
                cb_TipoFuenteFinanciamiento.DisplayMember = "Value";
                cb_TipoFuenteFinanciamiento.ValueMember = "Key";

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
            else
            {
                p = new FuenteFinanciamiento();
                p.nombre = tb_Nombre.Text;
                p.id_tff = ((KeyValuePair<int, string>)cb_TipoFuenteFinanciamiento.SelectedItem).Key; ;
                cp = new ControladorFuenteFinanciamiento(p);
                cp.Ingresar();

                l_ZonaMensaje.Text = "FuenteFinanciamiento fue ingresado con exito!";
                cb_TipoFuenteFinanciamiento.SelectedValue = 0;//funciona bien este!!!! para el combobox

                b_Guardar.Enabled = false;
                b_Actualizar.Enabled = true;
                b_Eliminar.Enabled = true;

                cp = new ControladorFuenteFinanciamiento(p);
                DataTable dt2 = new DataTable();
                dt2 = cp.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Id_FuenteFinanciamiento.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el ID de Fuente Financiamiento a Actualizar";

            }
            if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar un Nombre";
            }
            else if (tb_Nombre.TextLength >= 60)
            {
                l_ZonaMensaje.Text = "Debe ingresar un Nombre con 60 caracteres o menos";
            }
            else
            {
                p = new FuenteFinanciamiento();
                p.id_fuenteFinanciamiento = int.Parse(tb_Id_FuenteFinanciamiento.Text);
                p.id_tff = ((KeyValuePair<int, string>)cb_TipoFuenteFinanciamiento.SelectedItem).Key;
                p.nombre = tb_Nombre.Text;
                cp = new ControladorFuenteFinanciamiento(p);
                cp.Actualizar();
                dataGridView1.Refresh();
                l_ZonaMensaje.Text = "Fuente Financiamiento fue actualizado con exito!";

                tb_Id_FuenteFinanciamiento.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                cb_TipoFuenteFinanciamiento.SelectedValue = 0;
                b_Guardar.Enabled = true;
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;


                cp = new ControladorFuenteFinanciamiento(p);
                DataTable dt2 = new DataTable();
                dt2 = cp.ConsultarPorTodos();
                dataGridView1.DataSource = dt2;
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            p = new FuenteFinanciamiento();
            p.id_fuenteFinanciamiento = int.Parse(tb_Id_FuenteFinanciamiento.Text);
            cp = new ControladorFuenteFinanciamiento(p);
            cp.Eliminar();
            l_ZonaMensaje.Text = "Fuente Financiamiento fue eliminado con exito!";
            tb_Id_FuenteFinanciamiento.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            cb_TipoFuenteFinanciamiento.SelectedValue = 0;
            tb_Id_FuenteFinanciamiento.Enabled = true;
            tb_Id_FuenteFinanciamiento.Focus();
            dataGridView1.Refresh();
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            b_Guardar.Enabled = true;

            cp = new ControladorFuenteFinanciamiento(p);
            DataTable dt2 = new DataTable();
            dt2 = cp.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;

        }
        private void b_Consultar_Click(object sender, EventArgs e)//LISTO
        {
            cp = new ControladorFuenteFinanciamiento(p);
            DataTable dt2 = new DataTable();
            dt2 = cp.ConsultarPorTodos();
            dataGridView1.DataSource = dt2;
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_Id_FuenteFinanciamiento.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            
            tb_Id_FuenteFinanciamiento.Focus();
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
                tb_Id_FuenteFinanciamiento.Text = dataGridView1.Rows[e.RowIndex].Cells["id_fuenteFinanciamiento"].Value.ToString();
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                cb_TipoFuenteFinanciamiento.SelectedItem = (int)dataGridView1.Rows[e.RowIndex].Cells["id_tff"].Value;
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