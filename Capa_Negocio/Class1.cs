using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocio
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string? Nombre { get; set; } = string.Empty;
        public int? Edad { get; set; } = 0;
        public string Cedula { get; set; }
        
        public string Pasaporte { get; set; }
    }

}
