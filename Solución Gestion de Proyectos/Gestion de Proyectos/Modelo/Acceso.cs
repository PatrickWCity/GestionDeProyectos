using System;

namespace Gestion_de_Proyectos.Modelo
{
    class Acceso
    {
        public int id_acceso { get; set; }
        public int nroInterno { get; set; }
        public string username { get; set; }
        public string clave { get; set; }
        public int diasCad { get; set; }
        public DateTime fechaCaducidad { get; set; }
        public bool estadoInicial { get; set; }
        public string codigoAut { get; set; }
        public bool estadoAcceso { get; set; }
        public string pregunta { get; set; }
        public string respuesta { get; set; }

        public string claveNueva { get; set; }
    }
}
