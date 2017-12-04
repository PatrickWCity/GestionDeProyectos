using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Collections.Generic;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormCliente : Form
    {
        Cliente c = null;
        ControladorCliente cc = null;
        Localidad p = null;
        ControladorLocalidad cp = null;
        int id_cliente;
        public FormCliente()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;

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
            if (tb_Rut.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Domicilio.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos.";
            }
            else if (tb_Rut.TextLength == 0 || tb_Rut.TextLength == 10 || tb_Rut.TextLength == 9)
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
                    if (tb_Domicilio.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "La Direccion no puede estar vacio!";
                    }
                    else if (tb_Domicilio.TextLength > 255)
                    {
                        l_ZonaMensaje.Text = "La Diraccion supera el tamano maximo!";
                    }
                    else
                    {
                        c = new Cliente();
                        c.rut = tb_Rut.Text;
                        c.nombre = tb_Nombre.Text;
                        c.domicilio = tb_Domicilio.Text;
                        cc = new ControladorCliente(c);
                        cc.Ingresar();

                        l_ZonaMensaje.Text="Cliente fue ingresado con exito!";
                        tb_Rut.Text = string.Empty;
                        tb_Nombre.Text = string.Empty;
                        tb_Domicilio.Text = string.Empty;
                    }
                }
            }
            else if (tb_Rut.TextLength < 9)
            {
                l_ZonaMensaje.Text = "El Run esta incompleto!";
            }
            else if (tb_Rut.TextLength > 10)
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
            b_Actualizar.Enabled = false;

            if (tb_Rut.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Domicilio.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos.";
            }
            else if (tb_Rut.TextLength == 0 || tb_Rut.TextLength == 9 || tb_Rut.TextLength == 10)
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

                    if (tb_Domicilio.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "La Direccion no puede estar vacio!";
                    }
                    else if (tb_Domicilio.TextLength > 255)
                    {
                        l_ZonaMensaje.Text = "La Diraccion supera el tamano maximo";
                    }
                    else
                    {
                        c = new Cliente();
                        c.id_cliente = int.Parse(tb_Id_Cliente.Text);
                        c.rut = tb_Rut.Text;
                        c.nombre = tb_Nombre.Text;
                        c.domicilio = tb_Domicilio.Text;
                        cc = new ControladorCliente(c);
                        cc.Actualizar();
                        dataGridView1.Refresh();
                        l_ZonaMensaje.Text="Cliente fue actualizado con exito!";

                        tb_Id_Cliente.Text = string.Empty;
                        tb_Rut.Text = string.Empty;
                        tb_Nombre.Text = string.Empty;
                        tb_Domicilio.Text = string.Empty;
                        b_Guardar.Enabled = true;
                        b_Actualizar.Enabled = false;
                        b_Eliminar.Enabled = false;
                    }

                }
            }
            else if (tb_Rut.TextLength < 9)
            {
                l_ZonaMensaje.Text = "El Rut esta incompleto!";
            }
            else if (tb_Rut.TextLength > 10)
            {
                l_ZonaMensaje.Text = "El Rut supera los 10 digitos!";
            }
            else
            {
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que quiere Eliminar este Cliente ?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                c = new Cliente();
                c.id_cliente = int.Parse(tb_Id_Cliente.Text);
                cc = new ControladorCliente(c);
                cc.Eliminar();
                l_ZonaMensaje.Text="Cliente fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Cliente.Text = string.Empty;
                tb_Rut.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Domicilio.Text = string.Empty;
                tb_Id_Cliente.Enabled = true;
                tb_PalabraClave.Focus();
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
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Cliente.TextLength == 0)
            {
                cc = new ControladorCliente(c);
                DataTable dt = new DataTable();
                dt = cc.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Cliente.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    c = new Cliente();
                    c.id_cliente = 0;
                    c.palabraClave = tb_PalabraClave.Text;
                    cc = new ControladorCliente(c);
                    DataTable dt = new DataTable();
                    dataGridView1.Refresh();
                    dt = cc.ConsultarPorUno();
                    if (dt.Rows.Count ==1)
                    {
                        tb_Id_Cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                        tb_Rut.Text = dt.Rows[0]["rut"].ToString();
                        tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                        tb_Domicilio.Text = (string)dt.Rows[0]["domicilio"];
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
                if (int.TryParse(tb_Id_Cliente.Text, out id_cliente))
                {
                    if (id_cliente > 0)
                    {
                        c = new Cliente();
                        c.id_cliente = id_cliente;
                        c.palabraClave = tb_PalabraClave.Text;
                        cc = new ControladorCliente(c);
                        DataTable dt = new DataTable();
                        dt = cc.ConsultarPorUno();
                        if (dt.Rows.Count == 1)
                        {
                            tb_Id_Cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                            tb_Rut.Text = dt.Rows[0]["rut"].ToString();
                            tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                            tb_Domicilio.Text = (string)dt.Rows[0]["domicilio"];
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
                if (int.TryParse(tb_Id_Cliente.Text, out id_cliente))
                {
                    if (id_cliente > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            c = new Cliente();
                            c.id_cliente = id_cliente;
                            c.palabraClave = tb_PalabraClave.Text;
                            cc = new ControladorCliente(c);
                            DataTable dt = new DataTable();
                            dt = cc.ConsultarPorUno();
                            if (dt.Rows.Count ==1)
                            {
                                tb_Id_Cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                                tb_Rut.Text = dt.Rows[0]["rut"].ToString();
                                tb_Nombre.Text = (string)dt.Rows[0]["nombre"];
                                tb_Domicilio.Text = (string)dt.Rows[0]["domicilio"];
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

            tb_Id_Cliente.Text = string.Empty;
            tb_Rut.Text = string.Empty;
            tb_Nombre.Text = string.Empty;
            tb_Domicilio.Text = string.Empty;
            tb_Rut.Focus();
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
                tb_Id_Cliente.Text = dataGridView1.Rows[e.RowIndex].Cells["id_cliente1"].Value.ToString();
                tb_Rut.Text = dataGridView1.Rows[e.RowIndex].Cells["rut"].Value.ToString();
                tb_Nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                tb_Domicilio.Text = dataGridView1.Rows[e.RowIndex].Cells["domicilio"].Value.ToString();
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
