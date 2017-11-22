using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Collections.Generic;

namespace Gestion_de_Proyectos.Vista
{
    public partial class FormLocalidad : Form
    {
        Localidad l = null;
        ControladorLocalidad cl = null;
        int id_localidad;
        public FormLocalidad()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            b_Actualizar.Enabled = false;
            b_Eliminar.Enabled = false;

            cl = new ControladorLocalidad(l);
            DataTable dt = new DataTable();
            dt = cl.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Region");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test.Add((int)row[0], row[1].ToString());
                }
                comboBox1.DataSource = new BindingSource(test, null);
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }
            Dictionary<int, string> test2 = new Dictionary<int, string>();
            test2.Add(0, "Selecionar Providencia");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test2.Add((int)row[0], row[2].ToString());
                }
                comboBox2.DataSource = new BindingSource(test2, null);
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }

            Dictionary<int, string> test3 = new Dictionary<int, string>();
            test3.Add(0, "Selecionar Comuna");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test3.Add((int)row[0], row[3].ToString());
                }
                comboBox3.DataSource = new BindingSource(test3, null);
                comboBox3.DisplayMember = "Value";
                comboBox3.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }
        }
        private void b_Guardar_Click(object sender, EventArgs e)
        {
            if (tb_Region.TextLength == 0 && tb_Providencia.TextLength == 0 && tb_Comuna.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos.";
            }
            else if (tb_Region.TextLength == 0)
            {
                l_ZonaMensaje.Text = "region no puede estar vacio.";
            }
            else if (tb_Region.TextLength > 60)
            {
                l_ZonaMensaje.Text = "region supera los 60 caracteres";
            }
            else
            {

                if (tb_Providencia.TextLength == 0)
                {
                    l_ZonaMensaje.Text = "El providencia no puede estar vacio!";
                }
                else if (tb_Providencia.TextLength > 60)
                {
                    l_ZonaMensaje.Text = "El nombre supera el tamano maximo!";
                }
                else
                {
                    if (tb_Comuna.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno no puede estar vacio!";
                    }
                    else if (tb_Comuna.TextLength > 60)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno supera el tamano maximo!";
                    }
                    else
                    {
                            l = new Localidad();
                            l.region = tb_Region.Text;
                            l.providencia = tb_Providencia.Text;
                            l.comuna = tb_Comuna.Text;
                            l.id_localidad = 0;
                            cl = new ControladorLocalidad(l);
                            cl.Ingresar();

                            l_ZonaMensaje.Text="Localidad fue ingresado con exito!";
                            tb_Region.Text = string.Empty;
                            tb_Providencia.Text = string.Empty;
                            tb_Comuna.Text = string.Empty;

                        cl = new ControladorLocalidad(l);
                        DataTable dt = new DataTable();
                        dt = cl.ConsultarPorTodos();
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

            if (tb_Region.TextLength == 0 && tb_Providencia.TextLength == 0 && tb_Comuna.TextLength == 0)
            {
                l_ZonaMensaje.Text = "No ha ingresado los datos.";
            }
            else if (tb_Region.TextLength == 0)
            {
                l_ZonaMensaje.Text = "region no puede estar vacio.";
            }
            else if (tb_Region.TextLength > 60)
            {
                l_ZonaMensaje.Text = "region supera los 60 caracteres";
            }
            else
            {

                if (tb_Providencia.TextLength == 0)
                {
                    l_ZonaMensaje.Text = "El providencia no puede estar vacio!";
                }
                else if (tb_Providencia.TextLength > 60)
                {
                    l_ZonaMensaje.Text = "El nombre supera el tamano maximo!";
                }
                else
                {
                    if (tb_Comuna.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno no puede estar vacio!";
                    }
                    else if (tb_Comuna.TextLength > 60)
                    {
                        l_ZonaMensaje.Text = "El Apellido Paterno supera el tamano maximo!";
                    }
                    else
                    {

                            l = new Localidad();
                            l.id_localidad = int.Parse(tb_Id_Localidad.Text);
                            l.region = tb_Region.Text;
                            l.providencia = tb_Providencia.Text;
                            l.comuna = tb_Comuna.Text;
                            l.id_cliente = 0;
                            cl = new ControladorLocalidad(l);
                            cl.Actualizar();
                            dataGridView1.Refresh();
                            l_ZonaMensaje.Text="Localidad fue ingresado con exito!";

                            tb_Id_Localidad.Text = string.Empty;
                            tb_Region.Text = string.Empty;
                            tb_Providencia.Text = string.Empty;
                            tb_Comuna.Text = string.Empty;

                            b_Guardar.Enabled = true;
                            b_Actualizar.Enabled = false;
                            b_Eliminar.Enabled = false;


                        cl = new ControladorLocalidad(l);
                        DataTable dt = new DataTable();
                        dt = cl.ConsultarPorTodos();
                        dataGridView1.Refresh();
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void b_Eliminar_Click(object sender, EventArgs e)
        {
                l = new Localidad();
                l.id_localidad = int.Parse(tb_Id_Localidad.Text);
                cl = new ControladorLocalidad(l);
                cl.Eliminar();
                l_ZonaMensaje.Text="Usuario fue eliminado con exito!";
                tb_PalabraClave.Text = string.Empty;
                tb_Id_Localidad.Text = string.Empty;
                tb_Region.Text = string.Empty;
                tb_Providencia.Text = string.Empty;
                tb_Comuna.Text = string.Empty;
                tb_Id_Localidad.Enabled = true;
                tb_PalabraClave.Focus();
                dataGridView1.Refresh();
                b_Actualizar.Enabled = false;
                b_Eliminar.Enabled = false;
                b_Guardar.Enabled = true;

                cl = new ControladorLocalidad(l);
                DataTable dt = new DataTable();
                dt = cl.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
        }
        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_PalabraClave.TextLength == 0 && tb_Id_Localidad.TextLength == 0)
            {
                cl = new ControladorLocalidad(l);
                DataTable dt = new DataTable();
                dt = cl.ConsultarPorTodos();
                dataGridView1.Refresh();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }
            else if (tb_Id_Localidad.TextLength == 0)
            {
                if (tb_PalabraClave.TextLength <= 60)
                {
                    l = new Localidad();
                    l.id_localidad = 0;
                    l.palabraClave = tb_PalabraClave.Text;
                    cl = new ControladorLocalidad(l);
                    DataTable dt = new DataTable();
                    dataGridView1.Refresh();
                    dt = cl.ConsultarPorUno();
                   // if (dt.Rows.Count == 1)
                   // {
                     //   tb_Id_Localidad.Text = dt.Rows[0]["id_localidad"].ToString();
                    //    tb_Region.Text = dt.Rows[0]["region"].ToString();
                    //    tb_Providencia.Text = (string)dt.Rows[0]["providencia"];
                     //   tb_Comuna.Text = (string)dt.Rows[0]["comuna"];
                     //   l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";

                     //   tb_Region.Enabled = true;
                    //    tb_Providencia.Enabled = true;
                      //  tb_Comuna.Enabled = true;

                      //  b_Guardar.Enabled = false;
                    //   b_Actualizar.Enabled = true;
                    //  b_Eliminar.Enabled = true;

                    //   dataGridView1.Refresh();

                    // }
                    // else 
                    if (dt.Rows.Count > 1)
                    {
                        cl = new ControladorLocalidad(l);
                        dt = cl.ConsultarPorUno();
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
                    l_ZonaMensaje.Text = "Palabra clave debe ser menor a 60 caracteres.";
                }
            }
            else if (tb_PalabraClave.TextLength == 0)
            {
                if (int.TryParse(tb_Id_Localidad.Text, out id_localidad))
                {
                    if (id_localidad > 0)
                    {
                        l = new Localidad();
                        l.id_localidad = id_localidad;
                        l.palabraClave = tb_PalabraClave.Text;
                        cl = new ControladorLocalidad(l);
                        DataTable dt = new DataTable();
                        dt = cl.ConsultarPorUno();
                       // if (dt.Rows.Count ==0)
                       // {

                          //  tb_Id_Localidad.Text = dt.Rows[0]["id_localidad"].ToString();
                          //  tb_Region.Text = dt.Rows[0]["region"].ToString();
                          //  tb_Providencia.Text = (string)dt.Rows[0]["providencia"];
                          //  tb_Comuna.Text = (string)dt.Rows[0]["comuna"];
                          //  l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";

                          //  tb_Region.Enabled = true;
                           // tb_Providencia.Enabled = true;
                          //  tb_Comuna.Enabled = true;

                          //  b_Guardar.Enabled = false;
                          //  b_Actualizar.Enabled = true;
                          //  b_Eliminar.Enabled = true;

                          //  dataGridView1.Refresh();
                        //}
                        //else 
                        if (dt.Rows.Count > 1)
                        {
                            dataGridView1.Refresh();
                            dataGridView1.AutoGenerateColumns = false;
                            
                            l_ZonaMensaje.Text = "La Buscada fue finalizada con Exito!";
                            cl = new ControladorLocalidad(l);
                            dt = cl.ConsultarPorUno();
                            dataGridView1.Refresh();
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = dt;
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
                    l_ZonaMensaje.Text = "Debe Ingresar el número interno entero.";
                }
            }
            else
            {
                if (int.TryParse(tb_Id_Localidad.Text, out id_localidad))
                {
                    if (id_localidad > 0)
                    {
                        if (tb_PalabraClave.TextLength <= 60)
                        {
                            l = new Localidad();
                            l.id_localidad = id_localidad;
                            l.palabraClave = tb_PalabraClave.Text;
                            cl = new ControladorLocalidad(l);
                            DataTable dt = new DataTable();
                            dt = cl.ConsultarPorUno();
                            if (dt.Rows.Count > 0)
                            {

                                cl = new ControladorLocalidad(l);
                                dt = cl.ConsultarPorUno();
                                dataGridView1.Refresh();
                                dataGridView1.AutoGenerateColumns = false;
                                dataGridView1.DataSource = dt;
                            }
                            else if (dt.Rows.Count > 1)
                            {
                                cl = new ControladorLocalidad(l);
                                dt = cl.ConsultarPorUno();
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
            tb_Id_Localidad.Text = string.Empty;
            tb_Region.Text = string.Empty;
            tb_Providencia.Text = string.Empty;
            tb_Comuna.Text = string.Empty;
            tb_Region.Focus();
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
                tb_Id_Localidad.Text = dataGridView1.Rows[e.RowIndex].Cells["id_localidad1"].Value.ToString();
                tb_Region.Text = dataGridView1.Rows[e.RowIndex].Cells["region"].Value.ToString();
                tb_Providencia.Text = dataGridView1.Rows[e.RowIndex].Cells["providencia"].Value.ToString();
                tb_Comuna.Text = dataGridView1.Rows[e.RowIndex].Cells["comuna"].Value.ToString();
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