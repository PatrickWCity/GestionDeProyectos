using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormTipoFuenteFinanciamiento : Form
    {
        TipoFuenteFinanciamiento tff = null;
        ControladorTipoFuenteFinanciamiento ctff = null;
        int id_TipoFuenteFinanciamiento;
        public FormTipoFuenteFinanciamiento()
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
                    tff = new TipoFuenteFinanciamiento();
                    tff.nombre = tb_Nombre.Text;
                    tff.descripcion = tb_Descripcion.Text;
                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    ctff.Ingresar();
                    l_ZonaMensaje.Text="TipoFuenteFinanciamiento fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    DataTable dt = new DataTable();
                    dt = ctff.ConsultarPorTodos();
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
                    tff = new TipoFuenteFinanciamiento();
                    tff.nombre = tb_Nombre.Text;
                    tff.descripcion = tb_Descripcion.Text;
                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    ctff.Ingresar();
                    l_ZonaMensaje.Text="TipoFuenteFinanciamiento fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    DataTable dt = new DataTable();
                    dt = ctff.ConsultarPorTodos();
                    dataGridView1.Refresh();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            b_Actualizar.Enabled = false;

            if (tb_Id_TipoFuenteFinanciamiento.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
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
                    tff = new TipoFuenteFinanciamiento();
                    tff.id_tff = int.Parse(tb_Id_TipoFuenteFinanciamiento.Text);
                    tff.nombre = tb_Nombre.Text;
                    tff.descripcion = tb_Descripcion.Text;
                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    ctff.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="TipoFuenteFinanciamiento fue actualizado con exito!";

                    tb_Id_TipoFuenteFinanciamiento.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;

                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    DataTable dt = new DataTable();
                    dt = ctff.ConsultarPorTodos();
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
                    tff = new TipoFuenteFinanciamiento();
                    tff.id_tff = int.Parse(tb_Id_TipoFuenteFinanciamiento.Text);
                    tff.nombre = tb_Nombre.Text;
                    tff.descripcion = tb_Descripcion.Text;
                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    ctff.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="TipoFuenteFinanciamiento fue actualizado con exito!";

                    tb_Id_TipoFuenteFinanciamiento.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;

                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    DataTable dt = new DataTable();
                    dt = ctff.ConsultarPorTodos();
                    dataGridView1.Refresh();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
                tff = new TipoFuenteFinanciamiento();
                tff.id_tff = int.Parse(tb_Id_TipoFuenteFinanciamiento.Text);
                ctff = new ControladorTipoFuenteFinanciamiento(tff);
                ctff.Eliminar();
                l_ZonaMensaje.Text="TipoFuenteFinanciamiento fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_PalabraClave.Text = string.Empty;
                tb_Id_TipoFuenteFinanciamiento.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Descripcion.Text = string.Empty;
                tb_PalabraClave.Focus();
                tb_Id_TipoFuenteFinanciamiento.Enabled = true;
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;

            ctff = new ControladorTipoFuenteFinanciamiento(tff);
            DataTable dt = new DataTable();
            dt = ctff.ConsultarPorTodos();
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_Id_TipoFuenteFinanciamiento.TextLength == 0)
            {
                ctff = new ControladorTipoFuenteFinanciamiento(tff);
                DataTable dt = new DataTable();
                dt = ctff.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_TipoFuenteFinanciamiento.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {

                    tff = new TipoFuenteFinanciamiento();
                    tff.id_tff = 0;
                    tff.palabraClave = tb_PalabraClave.Text;
                    ctff = new ControladorTipoFuenteFinanciamiento(tff);
                    DataTable dt = new DataTable();
                    dataGridView1.Refresh();
                    dt = ctff.ConsultarPorUno();
                    if (dt.Rows.Count == 1)
                    {
                        tb_Id_TipoFuenteFinanciamiento.Text = dt.Rows[0]["id_tff"].ToString();
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
                    l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60";
                }
            }
            else if (tb_PalabraClave.TextLength == 0)
            {
                if (int.TryParse(tb_Id_TipoFuenteFinanciamiento.Text, out id_TipoFuenteFinanciamiento))
                {
                    if (id_TipoFuenteFinanciamiento > 0)
                    {
                        tff = new TipoFuenteFinanciamiento();
                        tff.id_tff = id_TipoFuenteFinanciamiento;
                        tff.palabraClave = tb_PalabraClave.Text;
                        ctff = new ControladorTipoFuenteFinanciamiento(tff);
                        DataTable dt = new DataTable();
                        dt = ctff.ConsultarPorUno();
                        if (dt.Rows.Count == 1)
                        {
                            tb_Id_TipoFuenteFinanciamiento.Text = dt.Rows[0]["id_tff"].ToString();
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
                if (int.TryParse(tb_Id_TipoFuenteFinanciamiento.Text, out id_TipoFuenteFinanciamiento))
                {
                    if (id_TipoFuenteFinanciamiento > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            tff = new TipoFuenteFinanciamiento();
                            tff.id_tff = id_TipoFuenteFinanciamiento;
                            tff.palabraClave = tb_PalabraClave.Text;
                            ctff = new ControladorTipoFuenteFinanciamiento(tff);
                            DataTable dt = new DataTable();
                            dt = ctff.ConsultarPorUno();
                            if (dt.Rows.Count == 1)
                            {
                                tb_Id_TipoFuenteFinanciamiento.Text = dt.Rows[0]["id_tff"].ToString();
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
            tb_Id_TipoFuenteFinanciamiento.Text = string.Empty;
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
                tb_Id_TipoFuenteFinanciamiento.Text = dataGridView1.Rows[e.RowIndex].Cells["id_tff"].Value.ToString();
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