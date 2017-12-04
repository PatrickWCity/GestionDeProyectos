using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormCargo : Form
    {
        Cargo c = null;
        ControladorCargo cc = null;
        int id_Cargo;
        public FormCargo()
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
                    c = new Cargo();
                    c.nombre = tb_Nombre.Text;
                    c.descripcion = tb_Descripcion.Text;
                    cc = new ControladorCargo(c);
                    cc.Ingresar();
                    l_ZonaMensaje.Text="Cargo fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;

                }
                else if (tb_Descripcion.TextLength > 255)
                {
                    l_ZonaMensaje.Text = "La descripcion supera los 255 char";
                }
                else
                {
                    c = new Cargo();
                    c.nombre = tb_Nombre.Text;
                    c.descripcion = tb_Descripcion.Text;
                    cc = new ControladorCargo(c);
                    cc.Ingresar();
                    l_ZonaMensaje.Text="Cargo fue ingresado con exito!";
                    tb_Nombre.Text = string.Empty;
                    tb_Descripcion.Text = string.Empty;
                }
            }
        }
        private void b_Actualizar_Click(object sender, EventArgs e)
        {
            if (tb_Id_Cargo.TextLength == 0 && tb_Nombre.TextLength == 0 && tb_Descripcion.TextLength == 0)
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
                    c = new Cargo();
                    c.id_cargo = int.Parse(tb_Id_Cargo.Text);
                    c.nombre = tb_Nombre.Text;
                    c.descripcion = tb_Descripcion.Text;
                    cc = new ControladorCargo(c);
                    cc.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Cargo fue actualizado con exito!";
                    tb_Id_Cargo.Text = string.Empty;
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
                    c = new Cargo();
                    c.id_cargo = int.Parse(tb_Id_Cargo.Text);
                    c.nombre = tb_Nombre.Text;
                    c.descripcion = tb_Descripcion.Text;
                    cc = new ControladorCargo(c);
                    cc.Actualizar();
                    dataGridView1.Refresh();
                    l_ZonaMensaje.Text="Cargo fue actualizado con exito!";
                    tb_Id_Cargo.Text = string.Empty;
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
            DialogResult result = MessageBox.Show("Esta seguro que quiere Eliminar este Cargo ?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                c = new Cargo();
                c.id_cargo = int.Parse(tb_Id_Cargo.Text);
                cc = new ControladorCargo(c);
                cc.Eliminar();
                l_ZonaMensaje.Text="Cargo fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Cargo.Text = string.Empty;
                tb_Nombre.Text = string.Empty;
                tb_Descripcion.Text = string.Empty;
                tb_PalabraClave.Focus();
                tb_Id_Cargo.Enabled = true;
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
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Cargo.TextLength == 0)
            {
                cc = new ControladorCargo(c);
                DataTable dt = new DataTable();
                dt = cc.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Cargo.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    l_ZonaMensaje.Text = "si se puede p";

                    c = new Cargo();
                    c.id_cargo = 0;
                    c.palabraClave = tb_PalabraClave.Text;
                    cc = new ControladorCargo(c);
                    DataTable dt = new DataTable();
                    dataGridView1.Refresh();
                    dt = cc.ConsultarPorUno();
                    if (dt.Rows.Count == 1)
                    {
                        tb_Id_Cargo.Text = dt.Rows[0]["id_cargo"].ToString();
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
                if (int.TryParse(tb_Id_Cargo.Text, out id_Cargo))
                {
                    l_ZonaMensaje.Text = "si es numero, ahora revisar si es >0 n";
                    if (id_Cargo > 0)
                    {
                        l_ZonaMensaje.Text = "si es >0, ahora se puede! n";
                        c = new Cargo();
                        c.id_cargo = id_Cargo;
                        c.palabraClave = tb_PalabraClave.Text;
                        cc = new ControladorCargo(c);
                        DataTable dt = new DataTable();
                        dt = cc.ConsultarPorUno();
                        if (dt.Rows.Count ==1)
                        {
                            tb_Id_Cargo.Text = dt.Rows[0]["id_cargo"].ToString();
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
                        l_ZonaMensaje.Text = "Debe Ingresar el número > 0 n";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero n";
                }
            }
            else//1
            {
                if (int.TryParse(tb_Id_Cargo.Text, out id_Cargo))
                {
                    if (id_Cargo > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            c = new Cargo();
                            c.id_cargo = id_Cargo;
                            c.palabraClave = tb_PalabraClave.Text;
                            cc = new ControladorCargo(c);
                            DataTable dt = new DataTable();
                            dt = cc.ConsultarPorUno();
                            if (dt.Rows.Count ==1 )
                            {
                                tb_Id_Cargo.Text = dt.Rows[0]["id_cargo"].ToString();
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
            tb_Id_Cargo.Text = string.Empty;
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
                tb_Id_Cargo.Text = dataGridView1.Rows[e.RowIndex].Cells["id_cargo1"].Value.ToString();
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
