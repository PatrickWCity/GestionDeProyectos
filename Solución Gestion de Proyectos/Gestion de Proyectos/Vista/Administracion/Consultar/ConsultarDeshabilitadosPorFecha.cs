using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Drawing;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarDeshabilitadosPorFecha : Form
    {
        HistoricoAcceso ha = null;
        ControladorHistoricoAcceso cha = null;
        DateTime fechaInicio;
        DateTime fechaFinal;
        int swbn;
        public ConsultarDeshabilitadosPorFecha()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
            swbn = (int)Properties.Settings.Default["CDF"];
            if (swbn == 1)
            {
                BackColor = DefaultForeColor;
            }
            else
            {
                BackColor = Color.Orange;
            }
        }

        private void b_Consultar_Click(object sender, EventArgs e)
        {
            if (tb_FechaInicio.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe Ingresar la fecha del trato";
                tb_FechaInicio.Focus();
            }
            else
            {
                if (DateTime.TryParse(tb_FechaInicio.Text, out fechaInicio))
                {
                    if (tb_FechaFinal.TextLength == 0)
                    {
                        l_ZonaMensaje.Text = "Debe Ingresar la fecha del trato";
                        tb_FechaFinal.Focus();
                    }
                    else
                    {
                        if (DateTime.TryParse(tb_FechaFinal.Text, out fechaFinal))
                        {
                            if (fechaInicio < fechaFinal)
                            {
                                ha = new HistoricoAcceso();
                                ha.fechaInicio = fechaInicio;
                                ha.fechaFinal = fechaFinal;
                                cha = new ControladorHistoricoAcceso(ha);
                                DataTable dt = new DataTable();
                                dt = cha.ConsultarDeshabilitadosPorFecha();
                                if (dt.Rows.Count > 0)
                                {
                                    dataGridView1.DataSource = dt;
                                }
                                else
                                {
                                    l_ZonaMensaje.Text = "No se encontro";
                                }
                            }
                            else
                            {
                                l_ZonaMensaje.Text = "La Fecha Inicial debe ser > a la Fecha Final";
                            }

                        }
                        else
                        {
                            l_ZonaMensaje.Text = "Debe ingresar una fecha del trato valida dd/mm/yyyy";
                            tb_FechaFinal.Focus();
                        }
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "Debe ingresar una fecha del trato valida dd/mm/yyyy";
                    tb_FechaInicio.Focus();
                }
            }
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }

        private void b_BN_Click(object sender, EventArgs e)
        {
            if (swbn == 0)
            {
                l_FechaFinal.ForeColor = DefaultBackColor;
                l_FechaInicio.ForeColor = DefaultBackColor;
                l_ZonaMensaje.ForeColor = DefaultBackColor;
                swbn = 1;
            }
            else
            {
                l_FechaFinal.ForeColor = DefaultForeColor;
                l_FechaInicio.ForeColor = DefaultForeColor;
                l_ZonaMensaje.ForeColor = DefaultForeColor;
                BackColor = Color.Orange;
                swbn = 0;
            }
            Properties.Settings.Default["CDF"] = swbn;
            Properties.Settings.Default.Save();
        }
    }
}
