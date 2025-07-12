using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocio
{

    public class NotaNegocio
    {
        private readonly ConexionDatos conexion;

        public NotaNegocio()
        {
            conexion = new ConexionDatos();
        }

        public DataTable ObtenerNotas()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    E.Nombre AS Estudiante,
                    M.Nombre AS Materia,
                    N.Calificacion AS Nota
                FROM Notas N
                INNER JOIN Estudiante E ON N.EstudianteId = E.Id
                INNER JOIN Materia M ON N.MateriaId = M.Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla); // <- Aquí llenas el DataTable con los resultados
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las notas: " + ex.Message, ex);
            }

            return tabla;
        }
    }

}
