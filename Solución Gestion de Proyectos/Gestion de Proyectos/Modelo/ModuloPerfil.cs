using System;

namespace Gestion_de_Proyectos.Modelo
{
    class ModuloPerfil
    {
        public int id_mp { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }
        public int id_perfil { get; set; }
        public int id_modulo { get; set; }
    }
}
