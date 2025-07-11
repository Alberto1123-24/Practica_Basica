using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Capa_Datos;
using Capa_Negocio;
using Microsoft.Data.SqlClient;
namespace Capa_Negocio
{
    public class EstudianteNegocio
    {
        private readonly ConexionDatos conexion;

        public EstudianteNegocio()
        {
            conexion = new ConexionDatos();
        }

        public List<MateriaNegocio.Materia> ObtenerMaterias()
        {

            MateriaNegocio materiaNegocio = new MateriaNegocio();
            return materiaNegocio.ObtenerMaterias();

        }

        public List<string> ObtenerNombresEstudiantes()
        {
            List<string> lista = new List<string>();

            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Nombre FROM Estudiante";
                    Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn);
                    Microsoft.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        lista.Add(reader["Nombre"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                // Puedes manejar el error como prefieras
                throw new Exception("Error al obtener estudiantes: " + ex.Message);
            }

            return lista;
        }
    }


    public class MateriaNegocio
    {
        private readonly ConexionDatos conexion;

        public MateriaNegocio()
        {
            conexion = new ConexionDatos();
        }

        // Clase interna para representar una materia
        public class Materia
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Creditos { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto permite que el ComboBox muestre el nombre
            }
        }

        public List<Materia> ObtenerMaterias()
        {
            List<Materia> lista = new List<Materia>();

            try
            {
                using (Microsoft.Data.SqlClient.SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Materia";
                    Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn);
                    Microsoft.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Materia materia = new Materia
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = reader["Nombre"].ToString(),
                            Creditos = Convert.ToInt32(reader["Creditos"])
                        };
                        lista.Add(materia);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener materias: " + ex.Message);
            }

            return lista;
        }

    }
}
