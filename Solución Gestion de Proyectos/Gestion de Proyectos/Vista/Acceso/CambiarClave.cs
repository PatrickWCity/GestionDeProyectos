using System;
using System.Data;
using System.Windows.Forms;
using Gestion_de_Proyectos.Modelo;
using Gestion_de_Proyectos.Controlador;
using System.Text.RegularExpressions;

namespace Gestion_de_Proyectos.Vista
{
    public partial class CambiarClave : Form
    {
        Acceso a = null;
        HistoricoPassword hp = null;
        ControladorHistoricoPassword chp = null;
        ControladorAcceso ca = null;
        public CambiarClave()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
        }

        private void b_CambiarClave_Click(object sender, EventArgs e)
        {
            a = new Acceso();
            hp = new HistoricoPassword();
            a.username = tb_Username.Text;
            hp.clave = tb_ConfirmarClaveNueva.Text;

            chp = new ControladorHistoricoPassword(a,hp);
            DataTable dt = new DataTable();
            dt = chp.VerificarClaveUsuario();
            if (dt.Rows.Count > 0)
            {
                l_Username.Text = "La Clave ya fue utilizada Anteriormente.";
            }
            else
            {
                FortalezaPassword checker = new FortalezaPassword();

                FortalezaPassword.PasswordStrength strength;
                strength = checker.GetPasswordStrength(tb_ClaveNueva.Text.ToString());
                string Fort = strength.ToString(); ;
                if (Fort == "Debil" || Fort == "Fuerte" || Fort == "Segura")
                {
                    if (tb_ClaveNueva.Text == tb_ConfirmarClaveNueva.Text)
                    {
                        a = new Acceso();
                        a.username = tb_Username.Text;
                        a.clave = tb_ClaveActual.Text;
                        a.claveNueva = tb_ClaveNueva.Text;
                        ca = new ControladorAcceso(a);
                        ca.ConsultaAcceso();
                        DataTable dt1 = new DataTable();
                        dt1 = ca.ConsultaAcceso();
                        if (dt1.Rows.Count == 1)
                        {
                            ca.ActualizarClave();
                            MessageBox.Show("Su Clave fue actualizada con exito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            l_ZonaMensaje.Text = "El Username y/o la clave actual esta incorrecta.";
                        }

                    }
                    else
                    {
                        l_ZonaMensaje.Text = "La Clave Nueva esta mal Confirmada.";
                    }
                }
                else
                {
                    l_ZonaMensaje.Text = "La Clave es Muy Debil!";
                }
            }
        }

        private void b_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tb_ClaveNueva_TextChanged(object sender, EventArgs e)
        {
            FortalezaPassword checker = new FortalezaPassword();

            FortalezaPassword.PasswordStrength strength;
            strength = checker.GetPasswordStrength(tb_ClaveNueva.Text.ToString());
            l_ZonaMensaje.Text = strength.ToString();
        }
    }
}
