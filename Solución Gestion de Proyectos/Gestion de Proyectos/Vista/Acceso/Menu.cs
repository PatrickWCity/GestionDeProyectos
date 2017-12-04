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
        private void ll_CambiarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarClave cc = new CambiarClave();
            cc.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //this.Dispose();
        }
        private void moduloAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarModuloPerfil mp = new AsignarModuloPerfil();
            mp.Show();
        }
        private void submoduloAModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarSubmoduloModulo sm = new AsignarSubmoduloModulo();
            sm.Show();
        }
        private void usuarioAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarUsuarioPerfil up = new AsignarUsuarioPerfil();
            up.Show();
        }
        private void moduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModulo m = new FormModulo();
            m.Show();
        }
        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerfil p = new FormPerfil();
            p.Show();
        }
        private void submoduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSubmodulo sm = new FormSubmodulo();
            sm.Show();
        }
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuario u = new FormUsuario();
            u.Show();
        }
        private void usuariosHabilitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarHabilitados h = new ConsultarHabilitados();
            h.Show();
        }
        private void usuariosDeshabilitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarDeshabilitados d = new ConsultarDeshabilitados();
            d.Show();
        }
        private void usuariosHabilitadosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarHabilitadosPorFecha hf = new ConsultarHabilitadosPorFecha();
            hf.Show();
        }
        private void usuariosDeshabilitadosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarDeshabilitadosPorFecha df = new ConsultarDeshabilitadosPorFecha();
            df.Show();
        }
        private void moduloDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarModulosDePerfil mp = new ConsultarModulosDePerfil();
            mp.Show();
        }
        private void submoduloDeModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarSubmoduloDeModulo sm = new ConsultarSubmoduloDeModulo();
            sm.Show();
        }
        private void usuariosDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuariosDePerfil up = new ConsultarUsuariosDePerfil();
            up.Show();
        }
        private void especialidadAEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarEspecialidadEmpleado ee = new AsignarEspecialidadEmpleado();
            ee.Show();
        }
        private void fuenteDeFinanciamientoAProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarFuenteFinanciamientoProyecto fp = new AsignarFuenteFinanciamientoProyecto();
            fp.Show();
        }
        private void itemAPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarItemPresupuesto ip = new AsignarItemPresupuesto();
            ip.Show();
        }
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargo c = new FormCargo();
            c.Show();
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente c = new FormCliente();
            c.Show();
        }
        private void empeadoAProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleadoProyecto ep = new FormEmpleadoProyecto();
            ep.Show();
        }
        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEspecialidad es = new FormEspecialidad();
            es.Show();
        }
        private void fuenteDeFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuenteFinanciamiento ff = new FormFuenteFinanciamiento();
            ff.Show();
        }
        private void gastoEjecutadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGastoEjecutado ge = new FormGastoEjecutado();
            ge.Show();
        }
        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItem i = new FormItem();
            i.Show();
        }
        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLocalidad l = new FormLocalidad();
            l.Show();
        }
        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPresupuesto p = new FormPresupuesto();
            p.Show();
        }
        private void proyectoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProyecto p = new FormProyecto();
            p.Show();
        }
        private void tipoDeFuenteDeFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoFuenteFinanciamiento tff = new FormTipoFuenteFinanciamiento();
            tff.Show();
        }
        private void cantidadDeProyectosPorCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCantidadProyectosPorCargo pc = new ConsultarCantidadProyectosPorCargo();
            pc.Show();
        }
        private void cantidadDeProyectosPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarCantidadProyectosPorEmpleado pe = new ConsultarCantidadProyectosPorEmpleado();
            pe.Show();
        }
        private void especialidadDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarEspecialidadDeEmpleado ee = new ConsultarEspecialidadDeEmpleado();
            ee.Show();
        }
        private void fuenteDeFinanciamientoDeProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarFuenteFinanciamientoDeProyecto ffp = new ConsultarFuenteFinanciamientoDeProyecto();
            ffp.Show();
        }
        private void itemDePresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarItemDePresupuesto ip = new ConsultarItemDePresupuesto();
            ip.Show();
        }
        private void disponibilidadDeEmpleadoPorEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPorDisponibilidadEmpleadoPorEspecialidad dee = new ConsultarPorDisponibilidadEmpleadoPorEspecialidad();
            dee.Show();
        }
        private void proyectosPorFinalizar3SemanasAntesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPorProyectoPorFinalizar3SemanasAntes pf3s = new ConsultarPorProyectoPorFinalizar3SemanasAntes();
            pf3s.Show();
        }
        private void proyectoGastoEjecutadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProyectoGEPresupuesto pgep = new ConsultaProyectoGEPresupuesto();
            pgep.Show();
        }
        private void rangoMontosFuenteDeFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRangoMontosFuenteFinanciamiento rmff = new ConsultarRangoMontosFuenteFinanciamiento();
            rmff.Show();
        }
        private void rangoMontosTipoDeFuenteDeFinanciamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarRangoMontosTipoFuenteFinanciamiento rmtff = new ConsultarRangoMontosTipoFuenteFinanciamiento();
            rmtff.Show();
        }
        private void reitemizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reitemizar r = new Reitemizar();
            r.Show();
        }
        private void graficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafico g = new Grafico();
            g.Show();
        }
    }
}