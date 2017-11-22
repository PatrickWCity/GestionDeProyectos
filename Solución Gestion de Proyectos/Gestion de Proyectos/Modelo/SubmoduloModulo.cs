using System;

namespace Gestion_de_Proyectos.Modelo
{
    class SubmoduloModulo
    {
        public int id_sm { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }
        public int id_modulo { get; set; }
        public int id_submodulo { get; set; }
    }
}
