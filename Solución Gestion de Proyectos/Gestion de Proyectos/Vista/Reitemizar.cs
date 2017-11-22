using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class Reitemizar : Form
    {
        Item i = null;
        ControladorItem ci = null;
        int total, monto11, monto22, editado;
        public Reitemizar()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
        }

        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Monto1.Text == "0" || tb_Monto1.TextLength == 0 || tb_Monto2.Text == "0" || tb_Monto2.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Monto no puede ser 0";
            }
            else if (int.Parse(l_Total.Text) > 0)
            {
                l_ZonaMensaje.Text = "Debe asignar el monto sin asignar";
            }
            {
                i = new Item();
                i.id_item = int.Parse(tb_Id_Item1.Text);
                i.nombre = tb_Nombre1.Text;
                i.descripcion = tb_Descripcion1.Text;
                i.monto = int.Parse(tb_Monto1.Text);
                ci = new ControladorItem(i);
                ci.Actualizar();
                dataGridView1.Refresh();
                

                tb_Id_Item1.Text = string.Empty;
                tb_Nombre1.Text = string.Empty;
                tb_Descripcion1.Text = string.Empty;
                tb_Monto1.Text = string.Empty;
                b_Actualizar.Enabled = false;


                i = new Item();
                i.id_item = int.Parse(tb_Id_Item2.Text);
                i.nombre = tb_Nombre2.Text;
                i.descripcion = tb_Descripcion2.Text;
                i.monto = int.Parse(tb_Monto2.Text);
                ci = new ControladorItem(i);
                ci.Actualizar();
                dataGridView1.Refresh();


                tb_Id_Item2.Text = string.Empty;
                tb_Nombre2.Text = string.Empty;
                tb_Descripcion2.Text = string.Empty;
                tb_Monto2.Text = string.Empty;
                b_Actualizar.Enabled = false;

                l_ZonaMensaje.Text = "Los montos de los Items fueron reitemizados con exito!";
            }
        }

        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_Id_Item1.Text = string.Empty;
            tb_Id_Item2.Text = string.Empty;
            tb_Nombre1.Text = string.Empty;
            tb_Nombre2.Text = string.Empty;
            tb_Monto1.Text = string.Empty;
            tb_Monto2.Text = string.Empty;
            b_Actualizar.Enabled = false;
        }

        private void b_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_Consultar_Click(object sender, EventArgs e)
        {
            ci = new ControladorItem(i);
            DataTable dt = new DataTable();
            dt = ci.ConsultarPorTodos();
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;

            ci = new ControladorItem(i);
            DataTable dt2 = new DataTable();
            dt2 = ci.ConsultarPorTodos();
            dataGridView2.Refresh();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt2;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["id_item1"].Value.ToString() == tb_Id_Item2.Text) { 
                    l_ZonaMensaje.Text = "Item no puede ser el mismo";
                b_Actualizar.Enabled = false; }
            else
            {
                tb_Id_Item1.Text = dataGridView1.Rows[e.RowIndex].Cells["id_item1"].Value.ToString();
                tb_Nombre1.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                tb_Descripcion1.Text = dataGridView1.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                tb_Monto1.Text = dataGridView1.Rows[e.RowIndex].Cells["monto"].Value.ToString();
                b_Actualizar.Enabled = true;
                if (tb_Monto1.TextLength == 0)
                {
                    tb_Monto1.Text = "0";
                }
                if (tb_Monto2.TextLength == 0)
                {
                    tb_Monto2.Text = "0";
                }
                l_Total.Text = ((int.Parse(tb_Monto1.Text) + int.Parse(tb_Monto2.Text)) - (int.Parse(tb_Monto1.Text) + int.Parse(tb_Monto2.Text))).ToString();
                total = int.Parse(tb_Monto1.Text) + int.Parse(tb_Monto2.Text);
                b_Actualizar.Enabled = true;
            }
            }
            else
            {

            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dataGridView2.Rows[e.RowIndex].Cells["id_item"].Value.ToString() == tb_Id_Item1.Text)
                {
                    l_ZonaMensaje.Text = "Item no puede ser el mismo";
                    b_Actualizar.Enabled = false;
                }
                else
                {

                    tb_Id_Item2.Text = dataGridView2.Rows[e.RowIndex].Cells["id_item"].Value.ToString();
                    tb_Nombre2.Text = dataGridView2.Rows[e.RowIndex].Cells["nombre2"].Value.ToString();
                    tb_Descripcion2.Text = dataGridView2.Rows[e.RowIndex].Cells["descripcion2"].Value.ToString();
                    tb_Monto2.Text = dataGridView2.Rows[e.RowIndex].Cells["monto2"].Value.ToString();
                    b_Actualizar.Enabled = true;
                    if (tb_Monto1.TextLength == 0)
                    {
                        tb_Monto1.Text = "0";
                    }
                    if (tb_Monto2.TextLength == 0)
                    {
                        tb_Monto2.Text = "0";
                    }
                    l_Total.Text = ((int.Parse(tb_Monto1.Text) + int.Parse(tb_Monto2.Text)) - (int.Parse(tb_Monto1.Text) + int.Parse(tb_Monto2.Text))).ToString();

                    total = int.Parse(tb_Monto1.Text) + int.Parse(tb_Monto2.Text);


                    b_Actualizar.Enabled = true;
                }

            }
            else
            {

            }
        }
        private void tb_Monto1_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_Monto1.Text, out int monto1))
            {
                l_ZonaMensaje.Text = "Monto de Primer item no es valido";
                b_Actualizar.Enabled = false;
            }
            else if (tb_Monto1.TextLength == 0)
            {
                tb_Monto1.Text = "0";
                l_ZonaMensaje.Text = "";
                b_Actualizar.Enabled = false;
            }
            else if (tb_Monto2.TextLength == 0)
            {
                tb_Monto2.Text = "0";
                l_ZonaMensaje.Text = "";
                b_Actualizar.Enabled = false;
            }
            else
            {
                monto11 = int.Parse(tb_Monto1.Text);
                monto22 = int.Parse(tb_Monto2.Text);
                editado = monto11 + monto22;
                l_Total.Text = (total - editado).ToString();
                b_Actualizar.Enabled = true;
            }
        }
        private void tb_Monto2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(tb_Monto2.Text, out int monto1))
            {
                l_ZonaMensaje.Text = "Monto de Segundo item no es valido";
                b_Actualizar.Enabled = false;
            }
            else if (tb_Monto1.TextLength == 0)
            {
                tb_Monto1.Text = "0";
                l_ZonaMensaje.Text = "";
                b_Actualizar.Enabled = false;
            }
            else if (tb_Monto2.TextLength == 0)
            {
                tb_Monto2.Text = "0";
                l_ZonaMensaje.Text = "";
                b_Actualizar.Enabled = false;
            }
            else
            {
                monto11 = int.Parse(tb_Monto1.Text);
                monto22 = int.Parse(tb_Monto2.Text);
                editado = monto11 + monto22;
                l_Total.Text = (total - editado).ToString();
                b_Actualizar.Enabled = true;
            }
        }
    }
}