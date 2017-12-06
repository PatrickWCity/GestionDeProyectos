using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Collections.Generic;
using System.Drawing;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormUsuario : Form
    {
        Usuario u = null;
        ControladorUsuario cu = null;
        Localidad p = null;
        ControladorLocalidad cp = null;
        Acceso a = null;
        ControladorAcceso ca = null;
        int nroInterno,telefono,swbn;
        public FormUsuario()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;


            swbn = (int)Properties.Settings.Default["Usuario"];
            if (swbn == 1)
            {
                label1.ForeColor = DefaultBackColor;
                l_Apmat.ForeColor = DefaultBackColor;
                l_Appat.ForeColor = DefaultBackColor;
                l_Direccion.ForeColor = DefaultBackColor;
                l_email.ForeColor = DefaultBackColor;
                l_Nombre.ForeColor = DefaultBackColor;
                l_NroInterno.ForeColor = DefaultBackColor;
                l_PalabraClave.ForeColor = DefaultBackColor;
                l_Run.ForeColor = DefaultBackColor;
                l_telefono.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                label1.ForeColor = DefaultForeColor;
                l_Apmat.ForeColor = DefaultForeColor;
                l_Appat.ForeColor = DefaultForeColor;
                l_Direccion.ForeColor = DefaultForeColor;
                l_email.ForeColor = DefaultForeColor;
                l_Nombre.ForeColor = DefaultForeColor;
                l_NroInterno.ForeColor = DefaultForeColor;
                l_PalabraClave.ForeColor = DefaultForeColor;
                l_Run.ForeColor = DefaultForeColor;
                l_telefono.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.LightSalmon;
            }

            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            l_ZonaMensaje.Text = "";

            cp = new ControladorLocalidad(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Localidad");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test.Add((int)row[0], row[3].ToString());
                }
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }
        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (tb_Run.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Appat.TextLength == 0 && tb_Apmat.TextLength == 0 && tb_Direccion.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos.";
            }
            else if (tb_Run.TextLength == 0 || tb_Run.TextLength == 10 || tb_Run.TextLength == 9)
            {
                if (tb_Nombre.TextLength == 0)
                {
                    l_ZonaMensaje.Text = "El nombre no puede estar vacio!";
                }
                else if (tb_Nombre.TextLength > 60)
                {
                    l_ZonaMensaje.Text = "El nombre supera el tamano maximo!";
                }
                else
                {
                    if (tb_Appat.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno no puede estar vacio!";
                    }
                    else if (tb_Appat.TextLength > 60)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno supera el tamano maximo!";
                    }
                    else
                    {
                        if (tb_Apmat.TextLength > 60)
                        {
                            l_ZonaMensaje.Text = "El Apellido Materno supera el tamano maximo!";
                        }
                        else
                        {
                            if (tb_Direccion.TextLength == 0)
                            {
                                l_ZonaMensaje.Text = "La Direccion no puede estar vacio!";
                            }
                            else if (tb_Direccion.TextLength > 255)
                            {
                                l_ZonaMensaje.Text = "La Diraccion supera el tamano maximo!";
                            }
                            else
                            {
                                if (tb_Telefono.TextLength <= 7 || tb_Telefono.TextLength >= 12)
                                {
                                    l_ZonaMensaje.Text = "El telefono debe ser de 8-11 digitos";
                                }
                                else if (!int.TryParse(tb_Telefono.Text, out telefono))
                                {
                                    l_ZonaMensaje.Text = "Numero invalido";
                                }
                                else
                                {
                                    if (tb_Email.TextLength == 0)
                                    {
                                        l_ZonaMensaje.Text = "Debe ingresar un correo";
                                    }
                                    else if (tb_Email.TextLength >= 256)
                                    {
                                        l_ZonaMensaje.Text = "debe ingresar un correo de 255 caracteres o menos";
                                    }
                                    else
                                    {
                                        u = new Usuario();
                                        u.run = tb_Run.Text;
                                        u.nombre = tb_Nombre.Text;
                                        u.appat = tb_Appat.Text;
                                        u.apmat = tb_Apmat.Text;
                                        u.direccion = tb_Direccion.Text;
                                        u.id_localidad = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                                        u.telefono = int.Parse(tb_Telefono.Text);
                                        u.email = tb_Email.Text;
                                        cu = new ControladorUsuario(u);
                                        cu.Ingresar();
                                        l_ZonaMensaje.Text = "Usuario fue ingresado con exito!";
                                        tb_Run.Text = string.Empty;
                                        tb_Nombre.Text = string.Empty;
                                        tb_Appat.Text = string.Empty;
                                        tb_Apmat.Text = string.Empty;
                                        tb_Direccion.Text = string.Empty;
                                        comboBox1.SelectedIndex = 0;
                                        tb_Email.Text = string.Empty;
                                        tb_Telefono.Text = string.Empty;
                                        cu = new ControladorUsuario(u);
                                        DataTable dt = new DataTable();
                                        dt = cu.ConsultarPorTodos();
                                        dataGridView1.Refresh();
                                        dataGridView1.AutoGenerateColumns = false;
                                        dataGridView1.DataSource = dt;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (tb_Run.TextLength < 9)
            {
                l_ZonaMensaje.Text = "El Run esta incompleto!";
            }
            else if (tb_Run.TextLength > 10)
            {
                l_ZonaMensaje.Text = "El Run supera los 10 digitos!";
            }
            else
            {
                l_ZonaMensaje.Text = "1";
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Run.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Appat.TextLength == 0 && tb_Apmat.TextLength == 0 && tb_Direccion.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos.";
            }
            else if (tb_Run.TextLength == 0 || tb_Run.TextLength == 9 || tb_Run.TextLength == 10)
            {
                if (tb_Nombre.TextLength == 0)
                {
                    l_ZonaMensaje.Text = "El nombre no puede estar vacio!";
                }
                else if (tb_Nombre.TextLength > 60)
                {
                    l_ZonaMensaje.Text = "El nombre supera el tamano maximo";
                }
                else
                {
                    if (tb_Appat.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno no puede estar vacio!";
                    }
                    else if (tb_Appat.TextLength > 60)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno supera el tamano maximo";
                    }
                    else
                    {
                        if (tb_Apmat.TextLength > 60)
                        {
                            l_ZonaMensaje.Text = "El Apellido Materno supera el tamano maximo";
                        }
                        else
                        {
                            if (tb_Direccion.TextLength == 0)
                            {
                                l_ZonaMensaje.Text = "La Direccion no puede estar vacio!";
                            }
                            else if (tb_Direccion.TextLength > 255)
                            {
                                l_ZonaMensaje.Text = "La Diraccion supera el tamano maximo";
                            }
                            else
                            {
                                if (tb_Telefono.TextLength <= 7 || tb_Telefono.TextLength >= 12)
                                {
                                    l_ZonaMensaje.Text = "El telefono debe ser de 8-11 digitos";
                                }
                                else if (!int.TryParse(tb_Telefono.Text, out telefono))
                                {
                                    l_ZonaMensaje.Text = "Numero invalido";
                                }
                                else
                                {
                                    if (tb_Email.TextLength == 0)
                                    {
                                        l_ZonaMensaje.Text = "Debe ingresar un correo";
                                    }
                                    else if (tb_Email.TextLength >= 256)
                                    {
                                        l_ZonaMensaje.Text = "debe ingresar un correo de 255 caracteres o menos";
                                    }
                                    else
                                    {
                                        u = new Usuario();
                                        u.nroInterno = int.Parse(tb_NroInterno.Text);
                                        u.run = tb_Run.Text;
                                        u.nombre = tb_Nombre.Text;
                                        u.appat = tb_Appat.Text;
                                        u.apmat = tb_Apmat.Text;
                                        u.direccion = tb_Direccion.Text;
                                        u.id_localidad = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                                        u.telefono = int.Parse(tb_Telefono.Text);
                                        u.email = tb_Email.Text;
                                        cu = new ControladorUsuario(u);
                                        cu.Actualizar();
                                        l_ZonaMensaje.Text = "Usuario fue actualizado con exito!";
                                        dataGridView1.Refresh();

                                        tb_NroInterno.Text = string.Empty;
                                        tb_Run.Text = string.Empty;
                                        tb_Nombre.Text = string.Empty;
                                        tb_Appat.Text = string.Empty;
                                        tb_Apmat.Text = string.Empty;
                                        tb_Direccion.Text = string.Empty;
                                        tb_Email.Text = string.Empty;
                                        tb_Telefono.Text = string.Empty;
                                        comboBox1.SelectedIndex = 0;
                                        b_Guardar.Enabled = true;
                                        b_Actualizar.Enabled = false;
                                        b_Eliminar.Enabled = false;
                                        cu = new ControladorUsuario(u);
                                        DataTable dt = new DataTable();
                                        dt = cu.ConsultarPorTodos();
                                        dataGridView1.Refresh();
                                        dataGridView1.AutoGenerateColumns = false;
                                        dataGridView1.DataSource = dt;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (tb_Run.TextLength < 9)
            {
                l_ZonaMensaje.Text = "El Run esta incompleto!";
            }
            else if (tb_Run.TextLength > 10)
            {
                l_ZonaMensaje.Text = "El Run supera los 10 digitos!";
            }
            else
            {
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
                u = new Usuario();
                u.nroInterno = int.Parse(tb_NroInterno.Text);
                cu = new ControladorUsuario(u);
                cu.Eliminar();
                l_ZonaMensaje.Text = "Usuario fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_NroInterno.Text = string.Empty;
                tb_Run.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Appat.Text = string.Empty;
                tb_Apmat.Text = string.Empty;
                tb_Direccion.Text = string.Empty;
                tb_NroInterno.Enabled = true;
                tb_PalabraClave.Focus();
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;
            tb_Email.Text = string.Empty;
            tb_Telefono.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
            cu = new ControladorUsuario(u);
            DataTable dt = new DataTable();
            dt = cu.ConsultarPorTodos();
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_NroInterno.TextLength == 0)
            {
                cu = new ControladorUsuario(u);
                DataTable dt = new DataTable();
                dt = cu.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_NroInterno.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    u = new Usuario();
                    u.nroInterno = 0;
                    u.palabraClave = tb_PalabraClave.Text;
                    cu = new ControladorUsuario(u);
                    DataTable dt = new DataTable();
                    dataGridView1.Refresh();
                    dt = cu.ConsultarPorUno();
                    if (dt.Rows.Count == 1)
                    {
                        tb_NroInterno.Text = dt.Rows[0]["nroInterno"].ToString();
                        tb_Run.Text = dt.Rows[0]["run"].ToString();
                        tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                        tb_Appat.Text = (string)dt.Rows[0]["appat"];
                        tb_Apmat.Text = dt.Rows[0]["apmat"].ToString();
                        tb_Direccion.Text = (string)dt.Rows[0]["direccion"];
                        l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
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
                    l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60 caracteres";
                }
            }
            else if (tb_PalabraClave.TextLength == 0)
            {
                if (int.TryParse(tb_NroInterno.Text, out nroInterno))
                {
                    if (nroInterno > 0)
                    {
                        u = new Usuario();
                        u.nroInterno = nroInterno;
                        u.palabraClave = tb_PalabraClave.Text;
                        cu = new ControladorUsuario(u);
                        DataTable dt = new DataTable();
                        dt = cu.ConsultarPorUno();
                        if (dt.Rows.Count == 1)
                        {
                            tb_NroInterno.Text = dt.Rows[0]["nroInterno"].ToString();
                            tb_Run.Text = dt.Rows[0]["run"].ToString();
                            tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                            tb_Appat.Text = (string)dt.Rows[0]["appat"];
                            tb_Apmat.Text = dt.Rows[0]["apmat"].ToString();
                            tb_Direccion.Text = (string)dt.Rows[0]["direccion"];
                            l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
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
                        l_ZonaMensaje.Text = "Debe Ingresar el número > 0.";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero.";
                }
            }
            else
            {
                if (int.TryParse(tb_NroInterno.Text, out nroInterno))
                {
                    if (nroInterno > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            u = new Usuario();
                            u.nroInterno = nroInterno;
                            u.palabraClave = tb_PalabraClave.Text;
                            cu = new ControladorUsuario(u);
                            DataTable dt = new DataTable();
                            dt = cu.ConsultarPorUno();
                            if (dt.Rows.Count == 1)
                            {
                                tb_NroInterno.Text = dt.Rows[0]["nroInterno"].ToString();
                                tb_Run.Text = dt.Rows[0]["run"].ToString();
                                tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                                tb_Appat.Text = (string)dt.Rows[0]["appat"];
                                tb_Apmat.Text = dt.Rows[0]["apmat"].ToString();
                                tb_Direccion.Text = (string)dt.Rows[0]["direccion"];
                                l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
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
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero";
                }
            }
        }
        private void b_Restablecer_Click(object sender, EventArgs e)
        {
            tb_PalabraClave.Text = string.Empty;
            tb_NroInterno.Text = string.Empty;
            tb_Run.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            tb_Appat.Text = string.Empty;
            tb_Apmat.Text = string.Empty;
            tb_Direccion.Text = string.Empty;
            tb_Run.Focus();
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;
            b_Guardar.Enabled = true;
            tb_Email.Text = string.Empty;
            tb_Telefono.Text = string.Empty;
            comboBox1.SelectedIndex = 0;
        }
        private void b_Salir_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_NroInterno.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe selecionar un Usuario Primerto";
            }
            else if (!int.TryParse(tb_NroInterno.Text, out nroInterno))
            {
                l_ZonaMensaje.Text = "ID es invalido";
            }
            else
            {
                //habilitar
                a = new Acceso();
                a.nroInterno = int.Parse(tb_NroInterno.Text);
                ca = new ControladorAcceso(a);
                ca.HabilitarAcceso();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_NroInterno.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe selecionar un Usuario Primerto";
            }
            else if (!int.TryParse(tb_NroInterno.Text, out nroInterno))
            {
                l_ZonaMensaje.Text = "ID es invalido";
            }
            else
            {
                a = new Acceso();
                a.nroInterno = int.Parse(tb_NroInterno.Text);
                ca = new ControladorAcceso(a);
                ca.DeshabilitarAcceso();
            }
        }

        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                label1.ForeColor = DefaultBackColor;
                l_Apmat.ForeColor = DefaultBackColor;
                l_Appat.ForeColor = DefaultBackColor;
                l_Direccion.ForeColor = DefaultBackColor;
                l_email.ForeColor = DefaultBackColor;
                l_Nombre.ForeColor = DefaultBackColor;
                l_NroInterno.ForeColor = DefaultBackColor;
                l_PalabraClave.ForeColor = DefaultBackColor;
                l_Run.ForeColor = DefaultBackColor;
                l_telefono.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                label1.ForeColor = DefaultForeColor;
                l_Apmat.ForeColor = DefaultForeColor;
                l_Appat.ForeColor = DefaultForeColor;
                l_Direccion.ForeColor = DefaultForeColor;
                l_email.ForeColor = DefaultForeColor;
                l_Nombre.ForeColor = DefaultForeColor;
                l_NroInterno.ForeColor = DefaultForeColor;
                l_PalabraClave.ForeColor = DefaultForeColor;
                l_Run.ForeColor = DefaultForeColor;
                l_telefono.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.LightSalmon;
                swbn = 0;
            }
            Properties.Settings.Default["Usuario"] = swbn;
            Properties.Settings.Default.Save();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tb_NroInterno.Text = dataGridView1.Rows[e.RowIndex].Cells["nroInterno1"].Value.ToString();
                tb_Run.Text = dataGridView1.Rows[e.RowIndex].Cells["run"].Value.ToString();
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                tb_Appat.Text = dataGridView1.Rows[e.RowIndex].Cells["appat"].Value.ToString();
                tb_Apmat.Text = dataGridView1.Rows[e.RowIndex].Cells["apmat"].Value.ToString();
                tb_Direccion.Text = dataGridView1.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                comboBox1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["comuna"].Value;
                tb_Telefono.Text = (string)dataGridView1.Rows[e.RowIndex].Cells["telefono1"].Value;
                tb_Email.Text =  (string)dataGridView1.Rows[e.RowIndex].Cells["email"].Value;
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