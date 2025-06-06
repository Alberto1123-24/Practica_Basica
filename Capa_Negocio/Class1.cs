using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocio
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cedula { get; set; }
        
        public string Pasaporte { get; set; }
    }
}
