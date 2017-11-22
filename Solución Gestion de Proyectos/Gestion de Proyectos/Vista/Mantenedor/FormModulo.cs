using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormModulo : Form
    {
        Modulo m = null;
        ControladorModulo cm = null;
        int id_Modulo;
        public FormModulo()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
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
                    m = new Modulo();
                    m.nombre = tb_Nombre.Text;
                    m.descripcion = tb_Descripcion.Text;
                    cm = new ControladorModulo(m);
                    cm.Ingresar();
                    l_ZonaMensaje.Text= "Modulo fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 char";
                }
                else
                {
                    m = new Modulo();
                    m.nombre = tb_Nombre.Text;
                    m.descripcion = tb_Descripcion.Text;
                    cm = new ControladorModulo(m);
                    cm.Ingresar();
                    l_ZonaMensaje.Text="Modulo fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;
                }
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            b_Actualizar.Enabled = false;

            if (tb_Id_Modulo.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
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
                    m = new Modulo();
                    m.id_modulo = int.Parse(tb_Id_Modulo.Text);
                    m.nombre = tb_Nombre.Text;
                    m.descripcion = tb_Descripcion.Text;
                    cm = new ControladorModulo(m);
                    cm.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Modulo fue actualizado con exito!";

                    tb_Id_Modulo.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 char";
                }
                else
                {
                    m = new Modulo();
                    m.id_modulo = int.Parse(tb_Id_Modulo.Text);
                    m.nombre = tb_Nombre.Text;
                    m.descripcion = tb_Descripcion.Text;
                    cm = new ControladorModulo(m);
                    cm.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Modulo fue actualizado con exito!";

                    tb_Id_Modulo.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere Eliminar este Modulo ?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                m = new Modulo();
                m.id_modulo = int.Parse(tb_Id_Modulo.Text);
                cm = new ControladorModulo(m);
                cm.Eliminar();
                l_ZonaMensaje.Text="Modulo fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Modulo.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Descripcion.Text = string.Empty;
                tb_PalabraClave.Focus();
                tb_Id_Modulo.Enabled = true;
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;
            }
            else if (result == DialogResult.No)
            {
                l_ZonaMensaje.Text = "Cancelo la Eliminacion de usuario";
            }
            else
            {
                l_ZonaMensaje.Text="La accion fue Cancelada!";
            }
        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Modulo.TextLength == 0)
            {
                cm = new ControladorModulo(m);
                DataTable dt = new DataTable();
                dt = cm.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Modulo.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    l_ZonaMensaje.Text = "si se puede p";

                    m = new Modulo();
                    m.id_modulo = 0;
                    m.palabraClave = tb_PalabraClave.Text;
                    cm = new ControladorModulo(m);
                    DataTable dt = new DataTable();
                    dt = cm.ConsultarPorUno();
                    if (dt.Rows.Count == 1)
                    {
                        tb_Id_Modulo.Text = dt.Rows[0]["id_modulo"].ToString();
                        tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                        tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
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
                    l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60 p";
                }
            }
            else if (tb_PalabraClave.TextLength == 0)
            {
                l_ZonaMensaje.Text = "revisar si es numero n";
                if (int.TryParse(tb_Id_Modulo.Text, out id_Modulo))
                {
                    l_ZonaMensaje.Text = "si es numero, ahora revisar si es >0";
                    if (id_Modulo > 0)
                    {
                        l_ZonaMensaje.Text = "si es >0, ahora se puede!";
                        m = new Modulo();
                        m.id_modulo = id_Modulo;
                        m.palabraClave = tb_PalabraClave.Text;
                        cm = new ControladorModulo(m);
                        DataTable dt = new DataTable();
                        dt = cm.ConsultarPorUno();
                        if (dt.Rows.Count== 1)
                        {
                            tb_Id_Modulo.Text = dt.Rows[0]["id_modulo"].ToString();
                            tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                            tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                            l_ZonaMensaje.Text = "La Buscada fue Finalizada con Exito!";
                            b_Guardar.Enabled = false;
                            b_Actualizar.Enabled = true;
                            b_Eliminar.Enabled = true;
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
                        l_ZonaMensaje.Text = "Debe Ingresar el número > 0";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero";
                }
            }
            else
            {
                if (int.TryParse(tb_Id_Modulo.Text, out id_Modulo))
                {
                    if (id_Modulo > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            m = new Modulo();
                            m.id_modulo = id_Modulo;
                            m.palabraClave = tb_PalabraClave.Text;
                            cm = new ControladorModulo(m);
                            DataTable dt = new DataTable();
                            dt = cm.ConsultarPorUno();
                            if (dt.Rows.Count ==1)
                            {
                                tb_Id_Modulo.Text = dt.Rows[0]["id_modulo"].ToString();
                                tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                                tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
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
                            l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60";
                        }
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "Debe Ingresar el número > 0";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero";
                }
            }
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_PalabraClave.Text = string.Empty;

            tb_Id_Modulo.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            tb_Descripcion.Text = string.Empty;
            tb_Nombre.Focus();
            b_Guardar.Enabled = true;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
        }
        private void b_Salir_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tb_Id_Modulo.Text = dataGridView1.Rows[e.RowIndex].Cells["id_modulo1"].Value.ToString();
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                tb_Descripcion.Text = dataGridView1.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
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