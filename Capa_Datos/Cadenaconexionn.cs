using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class ConexionDatos
    {
        private readonly Microsoft.Data.SqlClient.SqlConnection Conexion;

        public ConexionDatos()
        {
            string cadenaConexion = "Server=.; Database=Practica_Basica1; Integrated Security=true; TrustServerCertificate=True";
            Conexion = new Microsoft.Data.SqlClient.SqlConnection(cadenaConexion);
        }

        public void Open()
        {
            if (Conexion == null)
            {
                throw new InvalidOperationException("La conexión no ha sido inicializada.");
            }

            if (Conexion.State == System.Data.ConnectionState.Closed)
            {
                Conexion.Open();
            }
        }

        public void Close()
        {
            if (Conexion != null && Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public Microsoft.Data.SqlClient.SqlConnection GetConnection()
        {
            return Conexion;
        }
    }
}
