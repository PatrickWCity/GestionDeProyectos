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
    public partial class ConsultarCantidadProyectosPorEmpleado : Form
    {
        EmpleadoProyecto c = null;//empleadoproyecto
        ControladorEmpleadoProyecto cc = null;//empleadoproyecto
        Proyecto p = null;//rpoyecto
        ControladorProyecto cp = null;
        Usuario cl = null;//usuario
        ControladorUsuario ccl = null;
        Cargo ca = null;
        ControladorCargo cca = null;
        public ConsultarCantidadProyectosPorEmpleado()
        {

            InitializeComponent(); Icon = Properties.Resources.Icon;

            DataTable dt = new DataTable();//usuario
            DataTable dt1 = new DataTable();//proyecto
            DataTable dt3 = new DataTable();
            cp = new ControladorProyecto(p);
            dt1 = cp.ConsultarPorTodos();

            ccl = new ControladorUsuario(cl);
            dt = ccl.ConsultarPorTodos();

            Dictionary<int, string> test1 = new Dictionary<int, string>();
            test1.Add(0, "Selecionar Empleado");

            if (dt.Rows.Count > 0)//usuario
            {
                foreach (DataRow row in dt.Rows)
                {
                    test1.Add((int)row[0], row[2].ToString() + " " + row[3].ToString() + " " + row[4].ToString());
                }
                cb_Empleado.DataSource = new BindingSource(test1, null);
                cb_Empleado.DisplayMember = "Value";
                cb_Empleado.ValueMember = "Key";

            }
            else
            {
                //l_ZonaMensaje.Text ="No hay Perfiles Disponible";
            }
            l_ZonaMensaje.Text = "";
        }

        private void cb_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = new EmpleadoProyecto();
            c.nroInterno = ((KeyValuePair<int, string>)cb_Empleado.SelectedItem).Key;
            cc = new ControladorEmpleadoProyecto(c);
            dataGridView1.DataSource = cc.ConsultarCantidadDeProyectoPorEmpleado();
        }
    }
}
