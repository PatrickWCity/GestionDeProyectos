using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Drawing;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormPerfil : Form
    {
        Perfil p = null;
        ControladorPerfil cp = null;
        int id_Perfil,swbn;
        public FormPerfil()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            l_ZonaMensaje.Text = "";
            b_Eliminar.Enabled = false;

            swbn = (int)Properties.Settings.Default["Perfil"];
            if (swbn == 1)
            {
                l_Descripcion.ForeColor = DefaultBackColor;
                l_Id_Perfil.ForeColor = DefaultBackColor;
                l_Nombre.ForeColor = DefaultBackColor;
                l_PalabraClave.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;

                BackColor = DefaultForeColor;
            }
            else
            {
                l_Descripcion.ForeColor = DefaultForeColor;
                l_Id_Perfil.ForeColor = DefaultForeColor;
                l_Nombre.ForeColor = DefaultForeColor;
                l_PalabraClave.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.LightSalmon;
            }
        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos";
            }
            else if (tb_Nombre.TextLength == 0)
            {
                l_ZonaMensaje.Text = "El nombre no puede estar vacio";
            }
            else if (tb_Nombre.TextLength > 255)
            {
                l_ZonaMensaje.Text = "El nombre supera el tamano maximo";
            }
            else
            {
                if (tb_Descripcion.TextLength == 0)
                {
                    p = new Perfil();
                    p.nombre = tb_Nombre.Text;
                    p.descripcion = tb_Descripcion.Text;
                    cp = new ControladorPerfil(p);
                    cp.Ingresar();
                    l_ZonaMensaje.Text="Perfil fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    cp = new ControladorPerfil(p);
                    DataTable dt = new DataTable();
                    dt = cp.ConsultarPorTodos();
                    dataGridView1.DataSource = dt;
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 caracteres";
                }
                else
                {
                    p = new Perfil();
                    p.nombre = tb_Nombre.Text;
                    p.descripcion = tb_Descripcion.Text;
                    cp = new ControladorPerfil(p);
                    cp.Ingresar();
                    l_ZonaMensaje.Text="Perfil fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    cp = new ControladorPerfil(p);
                    DataTable dt = new DataTable();
                    dt = cp.ConsultarPorTodos();
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            b_Actualizar.Enabled = false;

            if (tb_Id_Perfil.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
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
                    p = new Perfil();
                    p.id_perfil = int.Parse(tb_Id_Perfil.Text);
                    p.nombre = tb_Nombre.Text;
                    p.descripcion = tb_Descripcion.Text;
                    cp = new ControladorPerfil(p);
                    cp.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Perfil fue actualizado con exito!";

                    tb_Id_Perfil.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;

                    cp = new ControladorPerfil(p);
                    DataTable dt = new DataTable();
                    dt = cp.ConsultarPorTodos();
                    dataGridView1.DataSource = dt;
                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 caracteres";
                }
                else
                {
                    p = new Perfil();
                    p.id_perfil = int.Parse(tb_Id_Perfil.Text);
                    p.nombre = tb_Nombre.Text;
                    p.descripcion = tb_Descripcion.Text;
                    cp = new ControladorPerfil(p);
                    cp.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Perfil fue actualizado con exito!";

                    tb_Id_Perfil.Text = string.Empty;
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                    b_Guardar.Enabled = true;
                    b_Actualizar.Enabled = false;
                    b_Eliminar.Enabled = false;

                    cp = new ControladorPerfil(p);
                    DataTable dt = new DataTable();
                    dt = cp.ConsultarPorTodos();
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere Eliminar este Perfil ?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                p = new Perfil();
                p.id_perfil = int.Parse(tb_Id_Perfil.Text);
                cp = new ControladorPerfil(p);
                cp.Eliminar();
                l_ZonaMensaje.Text="Perfil fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Perfil.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Descripcion.Text = string.Empty;
                tb_Id_Perfil.Enabled = true;
                tb_PalabraClave.Focus();
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;

                cp = new ControladorPerfil(p);
                DataTable dt = new DataTable();
                dt = cp.ConsultarPorTodos();
                dataGridView1.DataSource = dt;
            }
            else if (result == DialogResult.No)
            {
                l_ZonaMensaje.Text = "Cancelo la Eliminacion de Perfil";
            }
            else
            {
                l_ZonaMensaje.Text="La accion fue Cancelada!";
            }
        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Perfil.TextLength == 0)
            {
                cp = new ControladorPerfil(p);
                DataTable dt = new DataTable();
                dt = cp.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Perfil.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    p = new Perfil();
                    p.id_perfil = 0;
                    p.palabraClave = tb_PalabraClave.Text;
                    cp = new ControladorPerfil(p);
                    DataTable dt = new DataTable();
                    dt = cp.ConsultarPorUno();
                    if (dt.Rows.Count == 1)
                    {
                        tb_Id_Perfil.Text = dt.Rows[0]["id_perfil"].ToString();
                        tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                        tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                        l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
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
                    l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60 caracteres";
                }
            }
            else if (tb_PalabraClave.TextLength == 0)
            {
                if (int.TryParse(tb_Id_Perfil.Text, out id_Perfil))
                {
                    if (id_Perfil > 0)
                    {
                        p = new Perfil();
                        p.id_perfil = id_Perfil;
                        p.palabraClave = tb_PalabraClave.Text;
                        cp = new ControladorPerfil(p);
                        DataTable dt = new DataTable();
                        dt = cp.ConsultarPorUno();
                        if (dt.Rows.Count ==1)
                        {
                            tb_Id_Perfil.Text = dt.Rows[0]["id_perfil"].ToString();
                            tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                            tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                            l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
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
                if (int.TryParse(tb_Id_Perfil.Text, out id_Perfil))
                {
                    if (id_Perfil > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            p = new Perfil();
                            p.id_perfil = id_Perfil;
                            p.palabraClave = tb_PalabraClave.Text;
                            cp = new ControladorPerfil(p);
                            DataTable dt = new DataTable();
                            dt = cp.ConsultarPorUno();
                            if (dt.Rows.Count == 1)
                            {
                                tb_Id_Perfil.Text = dt.Rows[0]["id_perfil"].ToString();
                                tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                                tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                                l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
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
                            l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60 caracteres";
                        }
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "Debe Ingresar el número > 0";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero.";
                }
            }
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_PalabraClave.Text = string.Empty;
            tb_Id_Perfil.Text = string.Empty;
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
                tb_Id_Perfil.Text = dataGridView1.Rows[e.RowIndex].Cells["id_perfil1"].Value.ToString();
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

        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {

                l_Descripcion.ForeColor = DefaultBackColor;
                l_Id_Perfil.ForeColor = DefaultBackColor;
                l_Nombre.ForeColor = DefaultBackColor;
                l_PalabraClave.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;

                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Descripcion.ForeColor = DefaultForeColor;
                l_Id_Perfil.ForeColor = DefaultForeColor;
                l_Nombre.ForeColor = DefaultForeColor;
                l_PalabraClave.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.LightSalmon;
                swbn = 0;
            }
            Properties.Settings.Default["Perfil"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}
