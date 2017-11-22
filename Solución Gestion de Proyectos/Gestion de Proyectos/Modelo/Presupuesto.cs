using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Proyectos.Modelo
{
    class Presupuesto
    {
        public int id_presupuesto { get; set; }
        public int id_proyecto { get; set; }
        public string nombre { get; set; }
    }
}
