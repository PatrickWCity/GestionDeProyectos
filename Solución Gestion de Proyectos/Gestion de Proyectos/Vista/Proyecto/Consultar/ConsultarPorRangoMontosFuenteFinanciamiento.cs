using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarRangoMontosFuenteFinanciamiento : Form
    {
        FuenteFinanciamiento p = null;
        ControladorFuenteFinanciamiento cp = null;
        int swbn, monto1, monto2=0;
        public ConsultarRangoMontosFuenteFinanciamiento()
        {
            InitializeComponent();
            Icon = Properties.Resources.Icon;
            l_ZonaMensaje.Text = "";

            swbn = (int)Properties.Settings.Default["FuenteFinanciamiento"];
            if (swbn == 1)
            {
                label1.ForeColor = DefaultBackColor;
                label2.ForeColor = DefaultBackColor;
                label3.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
            }
            else
            {
                label1.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                label3.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = MyColor.SkyBlue;
            }
            cp = new ControladorFuenteFinanciamiento(p);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            dt = cp.ConsultarPorTodos();

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Selecionar Fuente de Financiamiento");

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
        }

        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                label1.ForeColor = DefaultBackColor;
                label2.ForeColor = DefaultBackColor;
                label3.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                BackColor = DefaultForeColor;
                swbn = 1;
            }
            else
            {
                label3.ForeColor = DefaultForeColor;
                label2.ForeColor = DefaultForeColor;
                label1.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = Color.Red;
                BackColor = MyColor.SkyBlue;
                swbn = 0;
            }
            Properties.Settings.Default["FuenteFinanciamiento"] = swbn;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_monto1.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe Ingresar el Monto Minimo del Rango a Consultar";
                tb_monto1.Focus();
            }
            else
            {
                if (int.TryParse(tb_monto1.Text, out monto1))
                {
                    if (tb_monto2.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "Debe Ingresar el Monto Maximo del Rango a Consultar";
                        tb_monto2.Focus();
                    }
                    else
                    {
                        if (int.TryParse(tb_monto2.Text, out monto2))
                        {
                            if (monto1 < monto2)
                            {
                                p = new FuenteFinanciamiento();
                                p.monto1 = monto1;
                                p.monto2 = monto2;
                                p.id_fuenteFinanciamiento = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                                cp = new ControladorFuenteFinanciamiento(p);
                                DataTable dt = new DataTable();
                                dt = cp.ConsultarProyectosRangoMontoFuenteFinanciamiento();
                                if (dt.Rows.Count > 0)
                                {
                                    dataGridView1.DataSource = dt;
                                    l_ZonaMensaje.Text = "";
                                }
                                else
                                {
                                    l_ZonaMensaje.Text = "No se encontro";
                                }
                            }
                            else
                            {
                                l_ZonaMensaje.Text = "El Monto Minimo debe ser > que el Monto Maximo";
                            }

                        }
                        else
                        {
                            l_ZonaMensaje.Text = "Debe ingresar un Monto Maximo Valido";
                            tb_monto2.Focus();
                        }
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe ingresar un Monto Minimo Valido";
                    tb_monto1.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            tb_monto1.Text = string.Empty;
            tb_monto2.Text = string.Empty;
            tb_monto1.Focus();
        }
    }
}
