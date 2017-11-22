using System;

namespace Gestion_de_Proyectos.Modelo
{
    class UsuarioPerfil
    {
        public int id_up { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }
        public int nroInterno { get; set; }
        public int id_perfil { get; set; }
    }
}
