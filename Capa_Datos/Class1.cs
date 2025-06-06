using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Datos
{
    public class ConexionDatos
    {
        private Microsoft.Data.SqlClient.SqlConnection Conexion;
        public ConexionDatos()
        {
            Conexion = new Microsoft.Data.SqlClient.SqlConnection("Server=.; Database=Practica_Basica1; Integrated Security=true; TrustServerCertificate=True");
        }

        public void Open()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
                Conexion.Open();
        }

        public void Close()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Close();
        }

        public Microsoft.Data.SqlClient.SqlConnection GetConnection()
        {
            return Conexion;
        }
    }
}
