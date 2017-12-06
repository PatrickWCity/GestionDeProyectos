using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormEspecialidad : Form
    {
        Especialidad es = null;
        ControladorEspecialidad ce = null;
        int id_Especialidad;
        public FormEspecialidad()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            l_ZonaMensaje.Text = "";
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
                    es = new Especialidad();
                    es.nombre = tb_Nombre.Text;
                    es.descripcion = tb_Descripcion.Text;
                    ce = new ControladorEspecialidad(es);
                    ce.Ingresar();
                    l_ZonaMensaje.Text="Especialidad fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    ce = new ControladorEspecialidad(es);
                    DataTable dt = new DataTable();
                    dt = ce.ConsultarPorTodos();
                    dataGridView1.Refresh();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 char";
                }
                else
                {
                    es = new Especialidad();
                    es.nombre = tb_Nombre.Text;
                    es.descripcion = tb_Descripcion.Text;
                    ce = new ControladorEspecialidad(es);
                    ce.Ingresar();
                    l_ZonaMensaje.Text="Especialidad fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    ce = new ControladorEspecialidad(es);
                    DataTable dt = new DataTable();
                    dt = ce.ConsultarPorTodos();
                    dataGridView1.Refresh();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            b_Actualizar.Enabled = false;

            if (tb_Id_Especialidad.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos";
            }
            else if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "el nombre no puede estar vacio";
            }
            else if (tb_Nombre.TextLength > 60)
            {
                l_ZonaMensaje.Text = "El nombre supera el tamano maximo";
            }
            else
            {
                if (tb_Descripcion.TextLength == 0)
                {
                    es = new Especialidad();
                    es.id_especialidad = int.Parse(tb_Id_Especialidad.Text);
                    es.nombre = tb_Nombre.Text;
                    es.descripcion = tb_Descripcion.Text;
                    ce = new ControladorEspecialidad(es);
                    ce.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Especialidad fue actualizado con exito!";
                    tb_Id_Especialidad.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;
                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;

                    ce = new ControladorEspecialidad(es);
                    DataTable dt = new DataTable();
                    dt = ce.ConsultarPorTodos();
                    dataGridView1.Refresh();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 char";
                }
                else
                {
                    es = new Especialidad();
                    es.id_especialidad = int.Parse(tb_Id_Especialidad.Text);
                    es.nombre = tb_Nombre.Text;
                    es.descripcion = tb_Descripcion.Text;
                    ce = new ControladorEspecialidad(es);
                    ce.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Especialidad fue actualizado con exito!";

                    tb_Id_Especialidad.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;
                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;

                    ce = new ControladorEspecialidad(es);
                    DataTable dt = new DataTable();
                    dt = ce.ConsultarPorTodos();
                    dataGridView1.Refresh();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
                es = new Especialidad();
                es.id_especialidad = int.Parse(tb_Id_Especialidad.Text);
                ce = new ControladorEspecialidad(es);
                ce.Eliminar();
                l_ZonaMensaje.Text="Especialidad fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Especialidad.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Descripcion.Text = string.Empty;
                tb_PalabraClave.Focus();
                tb_Id_Especialidad.Enabled = true;
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;

            ce = new ControladorEspecialidad(es);
            DataTable dt = new DataTable();
            dt = ce.ConsultarPorTodos();
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;

        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Especialidad.TextLength == 0)
            {
                ce = new ControladorEspecialidad(es);
                DataTable dt = new DataTable();
                dt = ce.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Especialidad.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    l_ZonaMensaje.Text = "si se puede p";

                    es = new Especialidad();
                    es.id_especialidad = 0;
                    es.palabraClave = tb_PalabraClave.Text;
                    ce = new ControladorEspecialidad(es);
                    DataTable dt = new DataTable();
                    dataGridView1.Refresh();
                    dt = ce.ConsultarPorUno();
                    if (dt.Rows.Count ==1)
                    {
                        tb_Id_Especialidad.Text = dt.Rows[0]["id_especialidad"].ToString();
                        tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                        tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                        l_ZonaMensaje.Text = "La Buscada fue Finalizada con Exito!";
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
                if (int.TryParse(tb_Id_Especialidad.Text, out id_Especialidad))
                {
                    if (id_Especialidad > 0)
                    {
                        es = new Especialidad();
                        es.id_especialidad = id_Especialidad;
                        es.palabraClave = tb_PalabraClave.Text;
                        ce = new ControladorEspecialidad(es);
                        DataTable dt = new DataTable();
                        dt = ce.ConsultarPorUno();
                        if (dt.Rows.Count ==1)
                        {
                            tb_Id_Especialidad.Text = dt.Rows[0]["id_especialidad"].ToString();
                            tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                            tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                            l_ZonaMensaje.Text = "La Buscada fue Finalizada con Exito! n";
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
                l_ZonaMensaje.Text = "si se puede, revisar numero t";
                if (int.TryParse(tb_Id_Especialidad.Text, out id_Especialidad))
                {
                    l_ZonaMensaje.Text = "si es numero, ahora revisar si es >0 t";
                    if (id_Especialidad > 0)
                    {
                        l_ZonaMensaje.Text = "si es >0, t";
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            l_ZonaMensaje.Text = "si se puede t";
                            es = new Especialidad();
                            es.id_especialidad = id_Especialidad;
                            es.palabraClave = tb_PalabraClave.Text;
                            ce = new ControladorEspecialidad(es);
                            DataTable dt = new DataTable();
                            dt = ce.ConsultarPorUno();
                            if (dt.Rows.Count ==1)
                            {
                                tb_Id_Especialidad.Text = dt.Rows[0]["id_especialidad"].ToString();
                                tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                                tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                                l_ZonaMensaje.Text = "La Buscada fue Finalizada con Exito! t";
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

            tb_Id_Especialidad.Text = string.Empty;
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
                tb_Id_Especialidad.Text = dataGridView1.Rows[e.RowIndex].Cells["id_especialidad1"].Value.ToString();
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
