
namespace Gestion_de_Proyectos.Modelo
{
    class Localidad
    {
        public int id_localidad { get; set; }
        public int id_cliente { get; set; }
        public string region { get; set; }
        public string providencia { get; set; }
        public string comuna { get; set; }
        public string ciudad { get; set; }

        public string palabraClave { get; set; }
    }
}
