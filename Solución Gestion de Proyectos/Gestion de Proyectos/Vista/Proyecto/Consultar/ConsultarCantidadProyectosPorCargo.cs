using Gestion_de_Proyectos.Controlador;
using Gestion_de_Proyectos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Proyectos.Vista
{
    public partial class ConsultarCantidadProyectosPorCargo : Form
    {
        EmpleadoProyecto c = null;//empleadoproyecto
        ControladorEmpleadoProyecto cc = null;//empleadoproyecto
        Proyecto p = null;//rpoyecto
        ControladorProyecto cp = null;
        Usuario cl = null;//usuario
        ControladorUsuario ccl = null;
        Cargo ca = null;
        ControladorCargo cca = null;
        public ConsultarCantidadProyectosPorCargo()
        {
            InitializeComponent(); Icon = Properties.Resources.Icon;

            DataTable dt = new DataTable();//usuario

            cca = new ControladorCargo(ca);
            dt = cca.ConsultarPorTodos();

            Dictionary<int, string> test2 = new Dictionary<int, string>();
            test2.Add(0, "Selecionar Cargo");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    test2.Add((int)row[0], row[1].ToString());
                }
                cb_Cargo.DataSource = new BindingSource(test2, null);
                cb_Cargo.DisplayMember = "Value";
                cb_Cargo.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }

            l_ZonaMensaje.Text = "";
        }

        private void cb_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = new EmpleadoProyecto();

            c.id_cargo = ((KeyValuePair<int, string>)cb_Cargo.SelectedItem).Key;
            cc = new ControladorEmpleadoProyecto(c);
            dataGridView1.DataSource = cc.ConsultarCantidadDeProyectoPorCargo();
        }
    }
}