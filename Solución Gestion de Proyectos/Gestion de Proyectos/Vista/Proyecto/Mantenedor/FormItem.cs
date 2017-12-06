using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormItem : Form
    {
        Item i = null;
        ControladorItem ci = null;
        int id_Item;
        public FormItem()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;

            l_ZonaMensaje.Text = "";
        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0 && tb_Monto.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos";
            }
            else if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "el nombre no puede estar vacio";
            }
            else if (tb_Nombre.TextLength > 255)
            {
                l_ZonaMensaje.Text = "El nombre supera el tamano maximo";
            }
            else
            {
                if (tb_Descripcion.TextLength == 0)
                {
                    if (tb_Monto.Text == "0" || tb_Monto.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "Monto no puede ser 0";
                    }
                    else
                    {
                        i = new Item();
                        i.nombre = tb_Nombre.Text;
                        i.descripcion = tb_Descripcion.Text;
                        i.monto = int.Parse(tb_Monto.Text);
                        ci = new ControladorItem(i);
                        ci.Ingresar();
                        l_ZonaMensaje.Text="Item fue ingresado con exito!";
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Monto.Text = string.Empty;

                        ci = new ControladorItem(i);
                        DataTable dt = new DataTable();
                        dt = ci.ConsultarPorTodos();
                        dataGridView1.Refresh();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                    }
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 char";
                }
                else
                {
                    if (tb_Monto.Text == "0" || tb_Monto.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "Monto no puede ser 0";
                    }
                    else
                    {
                        i = new Item();
                        i.nombre = tb_Nombre.Text;
                        i.descripcion = tb_Descripcion.Text;
                        i.monto = int.Parse(tb_Monto.Text);
                        ci = new ControladorItem(i);
                        ci.Ingresar();
                        l_ZonaMensaje.Text="Item fue ingresado con exito!";
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Monto.Text = string.Empty;

                        ci = new ControladorItem(i);
                        DataTable dt = new DataTable();
                        dt = ci.ConsultarPorTodos();
                        dataGridView1.Refresh();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            b_Actualizar.Enabled = false;

            if (tb_Id_Item.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos";
            }
            else if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "el nombre no puede estar vacio";
            }
            else if (tb_Nombre.TextLength > 255)
            {
                l_ZonaMensaje.Text = "El nombre supera el tamano maximo";
            }
            else
            {
                l_ZonaMensaje.Text = "revisar desc";
                if (tb_Descripcion.TextLength == 0)
                {
                    if (tb_Monto.Text == "0" || tb_Monto.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "Monto no puede ser 0";
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "continuar sin descripcion";
                        i = new Item();
                        i.id_item = int.Parse(tb_Id_Item.Text);
                        i.nombre = tb_Nombre.Text;
                        i.descripcion = tb_Descripcion.Text;
                        i.monto = int.Parse(tb_Monto.Text);
                        ci = new ControladorItem(i);
                        ci.Actualizar();
                        dataGridView1.Refresh();
                        l_ZonaMensaje.Text="Item fue actualizado con exito!";

                        tb_Id_Item.Text = string.Empty;
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Monto.Text = string.Empty;
                        b_Guardar.Enabled = true;
                        b_Actualizar.Enabled = false;
                        b_Eliminar.Enabled = false;

                        ci = new ControladorItem(i);
                        DataTable dt = new DataTable();
                        dt = ci.ConsultarPorTodos();
                        dataGridView1.Refresh();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                    }
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 char";
                }
                else
                {
                    if (tb_Monto.Text == "0" || tb_Monto.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "Monto no puede ser 0";
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "continua con descripcion";
                        i = new Item();
                        i.id_item = int.Parse(tb_Id_Item.Text);
                        i.nombre = tb_Nombre.Text;
                        i.descripcion = tb_Descripcion.Text;
                        i.monto = int.Parse(tb_Monto.Text);
                        ci = new ControladorItem(i);
                        ci.Actualizar();
                        dataGridView1.Refresh();
                        l_ZonaMensaje.Text="Item fue actualizado con exito!";

                        tb_Id_Item.Text = string.Empty;
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Monto.Text = string.Empty;
                        b_Guardar.Enabled = true;
                        b_Actualizar.Enabled = false;
                        b_Eliminar.Enabled = false;

                        ci = new ControladorItem(i);
                        DataTable dt = new DataTable();
                        dt = ci.ConsultarPorTodos();
                        dataGridView1.Refresh();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
                i = new Item();
                i.id_item = int.Parse(tb_Id_Item.Text);
                ci = new ControladorItem(i);
                ci.Eliminar();
                l_ZonaMensaje.Text="Item fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Item.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Descripcion.Text = string.Empty;
                tb_Monto.Text = string.Empty;
                tb_PalabraClave.Focus();
                tb_Id_Item.Enabled = true;
                tb_PalabraClave.Focus();
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;
        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Item.TextLength == 0)
            {
                ci = new ControladorItem(i);
                DataTable dt = new DataTable();
                dt = ci.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Item.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    l_ZonaMensaje.Text = "si se puede p";

                    i = new Item();
                    i.id_item = 0;
                    i.palabraClave = tb_PalabraClave.Text;
                    ci = new ControladorItem(i);
                    DataTable dt = new DataTable();
                    dataGridView1.Refresh();
                    dt = ci.ConsultarPorUno();
                    if (dt.Rows.Count ==1)
                    {
                        tb_Id_Item.Text = dt.Rows[0]["id_item"].ToString();
                        tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                        tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                        tb_Monto.Text = (string)dt.Rows[0]["monto"];
                        l_ZonaMensaje.Text = "La Buscada fue Finalizada con Exito!";
                        b_Guardar.Enabled = false;
                        b_Actualizar.Enabled = true;
                        b_Eliminar.Enabled = true;

                        dataGridView1.Refresh();
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        dataGridView1.Refresh();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                        l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "No se encontro";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60";
                }
            }
            else if (tb_PalabraClave.TextLength == 0)
            {
                l_ZonaMensaje.Text = "revisar si es numero";
                if (int.TryParse(tb_Id_Item.Text, out id_Item))
                {
                    l_ZonaMensaje.Text = "si es numero, ahora revisar si es >0";
                    if (id_Item > 0)
                    {
                        l_ZonaMensaje.Text = "si es >0, ahora se puede!";
                        i = new Item();
                        i.id_item = id_Item;
                        i.palabraClave = tb_PalabraClave.Text;
                        ci = new ControladorItem(i);
                        DataTable dt = new DataTable();
                        dt = ci.ConsultarPorUno();
                        if (dt.Rows.Count > 0)
                        {
                            tb_Id_Item.Text = dt.Rows[0]["id_item"].ToString();
                            tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                            tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                            tb_Monto.Text = (string)dt.Rows[0]["monto"];
                            l_ZonaMensaje.Text = "La Buscada fue Finalizada con Exito!";
                            b_Guardar.Enabled = false;
                            b_Actualizar.Enabled = true;
                            b_Eliminar.Enabled = true;

                            dataGridView1.Refresh();
                        }
                        else if (dt.Rows.Count > 1)
                        {
                            dataGridView1.Refresh();
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = dt;
                            l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
                        }
                        else
                        {
                            l_ZonaMensaje.Text = "No se encontro";
                        }
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "Debe Ingresar el número > 0 n";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero n";
                }
            }
            else
            {
                if (int.TryParse(tb_Id_Item.Text, out id_Item))
                {
                    if (id_Item > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            i = new Item();
                            i.id_item = id_Item;
                            i.palabraClave = tb_PalabraClave.Text;
                            ci = new ControladorItem(i);
                            DataTable dt = new DataTable();
                            dt = ci.ConsultarPorUno();
                            if (dt.Rows.Count ==1)
                            {
                                tb_Id_Item.Text = dt.Rows[0]["id_item"].ToString();
                                tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                                tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                                tb_Monto.Text = (string)dt.Rows[0]["monto"];
                                l_ZonaMensaje.Text = "La Buscada fue Finalizada con Exito! t";
                                b_Guardar.Enabled = false;
                                b_Actualizar.Enabled = true;
                                b_Eliminar.Enabled = true;

                                dataGridView1.Refresh();
                            }
                            else if (dt.Rows.Count > 1)
                            {
                                dataGridView1.Refresh();
                                dataGridView1.AutoGenerateColumns = false;
                                dataGridView1.DataSource = dt;
                                l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
                            }
                            else
                            {
                                l_ZonaMensaje.Text = "No se encontro";
                            }
                        }
                        else
                        {
                            l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60 t";
                        }
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "Debe Ingresar el número > 0 t";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero t";
                }
            }
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_PalabraClave.Text = string.Empty;
            tb_Id_Item.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            tb_Descripcion.Text = string.Empty;
            tb_Monto.Text = string.Empty;
            tb_Nombre.Focus();
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            b_Guardar.Enabled = true;
        }
        private void b_Salir_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tb_Id_Item.Text = dataGridView1.Rows[e.RowIndex].Cells["id_item1"].Value.ToString();
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                tb_Descripcion.Text = dataGridView1.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                tb_Monto.Text = dataGridView1.Rows[e.RowIndex].Cells["monto"].Value.ToString();
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