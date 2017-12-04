using Gestion_de_Proyectos.Vista;
using System;
using System.Windows.Forms;

namespace Gestion_de_Proyectos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
