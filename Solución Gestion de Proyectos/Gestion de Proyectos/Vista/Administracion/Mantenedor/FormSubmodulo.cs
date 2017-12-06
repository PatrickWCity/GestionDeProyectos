using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Drawing;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormSubmodulo : Form
    {
        Submodulo s = null;
        ControladorSubmodulo cs = null;
        int id_Submodulo,swbn;
        public FormSubmodulo()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            l_ZonaMensaje.Text = "";
            swbn = (int)Properties.Settings.Default["Submodulo"];
            if (swbn == 1)
            {
                l_Descripcion.ForeColor = DefaultBackColor;
                l_Id_Submodulo.ForeColor = DefaultBackColor;
                l_Nombre.ForeColor = DefaultBackColor;
                l_PalabraClave.ForeColor = DefaultBackColor;
                l_Ubicacion.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;

                BackColor = DefaultForeColor;
            }
            else
            {
                l_Descripcion.ForeColor = DefaultForeColor;
                l_Id_Submodulo.ForeColor = DefaultForeColor;
                l_Nombre.ForeColor = DefaultForeColor;
                l_PalabraClave.ForeColor = DefaultForeColor;
                l_Ubicacion.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.LightSalmon;
            }
        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0 && tb_Ubicacion.TextLength == 0)
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
                    l_ZonaMensaje.Text = "continuar sin descripcion";
                    if (tb_Ubicacion.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "debe ingresar la ubicacion";
                    }
                    else if (tb_Ubicacion.TextLength > 255)
                    {
                        l_ZonaMensaje.Text = "la ubi supera los 255 characteres";
                    }
                    else
                    {
                        s = new Submodulo();
                        s.nombre = tb_Nombre.Text;
                        s.descripcion = tb_Descripcion.Text;
                        s.ubicacion = tb_Ubicacion.Text;
                        cs = new ControladorSubmodulo(s);
                        cs.Ingresar();
                        l_ZonaMensaje.Text="Subodulo fue actualizado con exito!";
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Ubicacion.Text = string.Empty;

                        cs = new ControladorSubmodulo(s);
                        DataTable dt = new DataTable();
                        dt = cs.ConsultarPorTodos();
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
                    l_ZonaMensaje.Text = "continua con descripcion";
                    if (tb_Ubicacion.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "debe ingresar la ubicacion";
                    }
                    else if (tb_Ubicacion.TextLength > 255)
                    {
                        l_ZonaMensaje.Text = "la ubi supera los 255 characteres";
                    }
                    else
                    {
                        s = new Submodulo();
                        s.nombre = tb_Nombre.Text;
                        s.descripcion = tb_Descripcion.Text;
                        s.ubicacion = tb_Ubicacion.Text;
                        cs = new ControladorSubmodulo(s);
                        cs.Ingresar();
                        l_ZonaMensaje.Text="Subodulo fue actualizado con exito!";
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Ubicacion.Text = string.Empty;

                        cs = new ControladorSubmodulo(s);
                        DataTable dt = new DataTable();
                        dt = cs.ConsultarPorTodos();
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

            if (tb_Id_Submodulo.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0 && tb_Ubicacion.TextLength == 0)
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
                    if (tb_Ubicacion.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "debe ingresar la ubicacion";
                    }
                    else if (tb_Ubicacion.TextLength > 255)
                    {
                        l_ZonaMensaje.Text = "la ubi supera los 255 characteres";
                    }
                    else
                    {
                        s = new Submodulo();
                        s.id_submodulo = int.Parse(tb_Id_Submodulo.Text);
                        s.nombre = tb_Nombre.Text;
                        s.descripcion = tb_Descripcion.Text;
                        s.ubicacion = tb_Ubicacion.Text;
                        cs = new ControladorSubmodulo(s);
                        cs.Actualizar();
                        dataGridView1.Refresh();
                        l_ZonaMensaje.Text="Subodulo fue actualizado con exito!";

                        tb_Id_Submodulo.Text = string.Empty;
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Ubicacion.Text = string.Empty;

                        b_Guardar.Enabled = true;
                        b_Actualizar.Enabled = false;
                        b_Eliminar.Enabled = false;

                        cs = new ControladorSubmodulo(s);
                        DataTable dt = new DataTable();
                        dt = cs.ConsultarPorTodos();
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
                    if (tb_Ubicacion.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "debe ingresar la ubicacion";
                    }
                    else if (tb_Ubicacion.TextLength > 255)
                    {
                        l_ZonaMensaje.Text = "la ubi supera los 255 characteres";
                    }
                    else
                    {
                        s = new Submodulo();
                        s.id_submodulo = int.Parse(tb_Id_Submodulo.Text);
                        s.nombre = tb_Nombre.Text;
                        s.descripcion = tb_Descripcion.Text;
                        s.ubicacion = tb_Ubicacion.Text;
                        cs = new ControladorSubmodulo(s);
                        cs.Actualizar();
                        dataGridView1.Refresh();
                        l_ZonaMensaje.Text="Subodulo fue actualizado con exito!";

                        tb_Id_Submodulo.Text = string.Empty;
                        tb_Nombre.Text = string.Empty;
                        tb_Descripcion.Text = string.Empty;
                        tb_Ubicacion.Text = string.Empty;

                        b_Guardar.Enabled = true;
                        b_Actualizar.Enabled = false;
                        b_Eliminar.Enabled = false;

                        cs = new ControladorSubmodulo(s);
                        DataTable dt = new DataTable();
                        dt = cs.ConsultarPorTodos();
                        dataGridView1.Refresh();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
                s = new Submodulo();
                s.id_submodulo = int.Parse(tb_Id_Submodulo.Text);
                cs = new ControladorSubmodulo(s);
                cs.Eliminar();
                l_ZonaMensaje.Text="Submodulo fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Submodulo.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Descripcion.Text = string.Empty;
                tb_Ubicacion.Text = string.Empty;
                tb_PalabraClave.Focus();
                tb_Id_Submodulo.Enabled = true;
                tb_PalabraClave.Focus();
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;
                cs = new ControladorSubmodulo(s);
                DataTable dt = new DataTable();
                dt = cs.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Submodulo.TextLength == 0)
            {
                cs = new ControladorSubmodulo(s);
                DataTable dt = new DataTable();
                dt = cs.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Submodulo.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    s = new Submodulo();
                    s.id_submodulo = 0;
                    s.palabraClave = tb_PalabraClave.Text;
                    cs = new ControladorSubmodulo(s);
                    DataTable dt = new DataTable();
                    dt = cs.ConsultarPorUno();
                    if (dt.Rows.Count == 1)
                    {
                        tb_Id_Submodulo.Text = dt.Rows[0]["id_submodulo"].ToString();
                        tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                        tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                        tb_Ubicacion.Text = (string)dt.Rows[0]["ubicacion"];
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
                    l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60";
                }
            }
            else if (tb_PalabraClave.TextLength == 0)
            {
                if (int.TryParse(tb_Id_Submodulo.Text, out id_Submodulo))
                {
                    if (id_Submodulo > 0)
                    {
                        s = new Submodulo();
                        s.id_submodulo = id_Submodulo;
                        s.palabraClave = tb_PalabraClave.Text;
                        cs = new ControladorSubmodulo(s);
                        DataTable dt = new DataTable();
                        dt = cs.ConsultarPorUno();
                        if (dt.Rows.Count == 1)
                        {
                            tb_Id_Submodulo.Text = dt.Rows[0]["id_submodulo"].ToString();
                            tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                            tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                            tb_Ubicacion.Text = (string)dt.Rows[0]["ubicacion"];
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
                if (int.TryParse(tb_Id_Submodulo.Text, out id_Submodulo))
                {
                    if (id_Submodulo > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            s = new Submodulo();
                            s.id_submodulo = id_Submodulo;
                            s.palabraClave = tb_PalabraClave.Text;
                            cs = new ControladorSubmodulo(s);
                            DataTable dt = new DataTable();
                            dt = cs.ConsultarPorUno();
                            if (dt.Rows.Count ==1)
                            {
                                tb_Id_Submodulo.Text = dt.Rows[0]["id_submodulo"].ToString();
                                tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                                tb_Descripcion.Text = dt.Rows[0]["descripcion"].ToString();
                                tb_Ubicacion.Text = (string)dt.Rows[0]["ubicacion"];
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

            tb_Id_Submodulo.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            tb_Descripcion.Text = string.Empty;
            tb_Ubicacion.Text = string.Empty;
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
                tb_Id_Submodulo.Text = dataGridView1.Rows[e.RowIndex].Cells["id_submodulo1"].Value.ToString();
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                tb_Descripcion.Text = dataGridView1.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                tb_Ubicacion.Text = dataGridView1.Rows[e.RowIndex].Cells["ubicacion"].Value.ToString();
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
                l_Id_Submodulo.ForeColor = DefaultBackColor;
                l_Nombre.ForeColor = DefaultBackColor;
                l_PalabraClave.ForeColor = DefaultBackColor;
                l_Ubicacion.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;

                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                l_Descripcion.ForeColor = DefaultForeColor;
                l_Id_Submodulo.ForeColor = DefaultForeColor;
                l_Nombre.ForeColor = DefaultForeColor;
                l_PalabraClave.ForeColor = DefaultForeColor;
                l_Ubicacion.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.LightSalmon;
                swbn = 0;
            }
            Properties.Settings.Default["Submodulo"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}
