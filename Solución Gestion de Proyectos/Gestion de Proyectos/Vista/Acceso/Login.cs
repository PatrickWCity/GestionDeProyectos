using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;

namespace Gestion_de_Proyectos.Vista
{
    public partial class Login : Form
    {
        Acceso a = null;
        ControladorAcceso ca = null;

        public Login()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
        }

        private void b_Aceptar_Click(object sender, EventArgs e)
        {

            if (tb_Username.TextLength == 0 && tb_Password.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el Username y la Clave.";
            }
            else if (tb_Username.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar el Username.";
            }
            else if (tb_Password.TextLength == 0)
            {
                l_ZonaMensaje.Text = "Debe ingresar la Clave.";
            }
            else
            {
                a = new Acceso();
                a.username = tb_Username.Text;
                a.clave = tb_Password.Text;
                ca = new ControladorAcceso(a);
                ca.ConsultaAccesoExisteUsername();
                DataTable dt6 = new DataTable();
                dt6 = ca.ConsultaAccesoExisteUsername();
                string username = dt6.Rows[0][0].ToString();
                if (username == "1")
                {
                    a = new Acceso();
                    a.username = tb_Username.Text;
                    a.clave = tb_Password.Text;
                    ca = new ControladorAcceso(a);
                    ca.ConsultaAccesoHabilitado();
                    DataTable dt4 = new DataTable();
                    dt4 = ca.ConsultaAccesoHabilitado();
                    if (dt4.Rows.Count == 1)
                    {
                        a = new Acceso();
                        a.username = tb_Username.Text;
                        a.clave = tb_Password.Text;
                        ca = new ControladorAcceso(a);
                        ca.ConsultaAccesoPrimero();
                        DataTable dt1 = new DataTable();
                        dt1 = ca.ConsultaAccesoPrimero();
                        if (dt1.Rows.Count == 1)
                        {
                            string primera = dt1.Rows[0][0].ToString();
                            if (primera == "0")
                            {
                                a = new Acceso();
                                a.username = tb_Username.Text;
                                a.clave = tb_Password.Text;
                                ca = new ControladorAcceso(a);
                                ca.ConsultaAcceso();
                                DataTable dt2 = new DataTable();
                                dt2 = ca.ConsultaAcceso();
                                string acceso = dt2.Rows[0][0].ToString();
                                if (acceso == "1")
                                {

                                    a = new Acceso();
                                    a.username = tb_Username.Text;
                                    a.clave = tb_Password.Text;
                                    ca = new ControladorAcceso(a);
                                    ca.ConsultaAccesoFechaCad();
                                    DataTable dt3 = new DataTable();
                                    dt3 = ca.ConsultaAccesoFechaCad();
                                    DateTime fechaCad = DateTime.Parse(dt3.Rows[0][0].ToString());
                                    int dias = (DateTime.Now - fechaCad).Days;
                                    if (dias > 7)
                                    {
                                        l_ZonaMensaje.Text = "Debe cambiar la Clave, su Clave ha caducado.";
                                    }
                                    else
                                    {
                                        Menu m = new Menu();
                                        m.Show();
                                        this.Close();
                                    }

                                }
                                else
                                {
                                    l_ZonaMensaje.Text = "Username y/o Clave Incorrecta.";
                                }

                            }
                            else
                            {
                                l_ZonaMensaje.Text = "Debe Cambiar la Clave, para ingresar por primera Vez.";
                            }
                        }

                        else
                        {
                            l_ZonaMensaje.Text = "2";
                        }
                    }
                    else
                    {
                        l_ZonaMensaje.Text = "accesso deshabilitado";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "no existe";
                }

            }
        }

        private void ll_CambiarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarClave cc = new CambiarClave();
            cc.Show();
        }

        private void b_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //dispose
        }
    }
}
