using System;

namespace Gestion_de_Proyectos.Modelo
{
    class HistoricoAcceso
    {
        public int id_ha { get; set; }
        public DateTime fecha { get; set; }
        public bool estado { get; set; }
        public int nroInterno { get; set; }

        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
    }
}
