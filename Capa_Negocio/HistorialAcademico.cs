using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Negocio
{
  
public class HistorialAcademico
    {
        private string conexion = "Server=.; Database=Practica_Basica1; Integrated Security=true; TrustServerCertificate=True";

        public List<DetalleNota> ObtenerHistorial(string estudiante)
        {
            List<DetalleNota> historial = new List<DetalleNota>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = @"
            SELECT M.Nombre AS Materia, N.Calificacion
            FROM Notas N
            INNER JOIN Estudiante E ON N.EstudianteId = E.Id
            INNER JOIN Materia M ON N.MateriaId = M.Id
            WHERE E.Nombre = @nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", estudiante);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    historial.Add(new DetalleNota
                    {
                        Materia = reader["Materia"].ToString(),
                        Calificacion = Convert.ToDouble(reader["Calificacion"])
                    });
                }
            }

            return historial;
        }

        public (double promedio, int cantidad) ObtenerResumen(string estudiante)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                string query = @"
            SELECT AVG(N.Calificacion) AS Promedio, COUNT(*) AS Cantidad
            FROM Notas N
            INNER JOIN Estudiante E ON N.EstudianteId = E.Id
            WHERE E.Nombre = @nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", estudiante);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                double promedio = 0;
                int cantidad = 0;

                if (reader.Read())
                {
                    promedio = reader["Promedio"] != DBNull.Value ? Convert.ToDouble(reader["Promedio"]) : 0;
                    cantidad = Convert.ToInt32(reader["Cantidad"]);
                }

                return (promedio, cantidad);
            }
        }
    }

}
