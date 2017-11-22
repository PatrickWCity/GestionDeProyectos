using System;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;
        }

        private void consultarPorUsuariosHabilitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarHabilitados ch = new ConsultarHabilitados();
            ch.Show();
        }

        private void consultarPorUsuariosDeshabilitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarDeshabilitados cd = new ConsultarDeshabilitados();
            cd.Show();
        }

        private void consultarPorLosUsuariosHabilitadosEnUnRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarHabilitadosPorFecha chpf = new ConsultarHabilitadosPorFecha();
            chpf.Show();
        }

        private void consultarPorLosUsuariosDeshabilitadosEnUnRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarDeshabilitadosPorFecha cdpf = new ConsultarDeshabilitadosPorFecha();
            cdpf.Show();
        }

        private void ll_CambiarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarClave cc = new CambiarClave();
            cc.Show();
        }

        private void usuarioPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarUsuarioPerfil aup = new AsignarUsuarioPerfil();
            aup.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario fu = new FormUsuario();
            fu.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerfil fp = new FormPerfil();
            fp.Show();
        }

        private void moduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModulo fm = new FormModulo();
            fm.Show();
        }

        private void submoduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubmodulo fs = new FormSubmodulo();
            fs.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente fcl = new FormCliente();
            fcl.Show();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEspecialidad fe = new FormEspecialidad();
            fe.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalidad fl = new FormLocalidad();
            fl.Show();
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItem fi = new FormItem();
            fi.Show();
        }

        private void tipoFuenteFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoFuenteFinanciamiento ft = new FormTipoFuenteFinanciamiento();
            ft.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargo fc = new FormCargo();
            fc.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProyecto p = new FormProyecto();
            p.Show();
        }

        private void fuenteFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuenteFinanciamiento ff = new FormFuenteFinanciamiento();
            ff.Show();
        }

        private void fuenteFinanciamientoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarFuenteFinanciamientoProyecto ffp = new AsignarFuenteFinanciamientoProyecto();
            ffp.Show();
        }

        private void empleadoDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleadoProyecto ep = new FormEmpleadoProyecto();
        }

        private void especialidadEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarEspecialidadEmpleado ee = new AsignarEspecialidadEmpleado();
            ee.Show();
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPresupuesto p = new FormPresupuesto();
            p.Show();
        }

        private void gastoEjecutadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGastoEjecutado ge = new FormGastoEjecutado();
            ge.Show();
        }

        private void itemPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarItemPresupuesto ip = new AsignarItemPresupuesto();
            ip.Show();
        }

        private void reitemizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reitemizar r = new Reitemizar();
            r.Show();
        }
    }
}
