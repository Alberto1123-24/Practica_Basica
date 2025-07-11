using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Microsoft.Data.SqlClient;
using static Capa_Negocio.MateriaNegocio;

namespace Capa_Negocio
{

    public class NotaFinal : NotaBase
    {
        private readonly ConexionDatos conexion;

        public NotaFinal(int estudianteId, int materiaId, decimal nota)
        : base(estudianteId, materiaId, nota)
        {
            conexion = new ConexionDatos();
        }

        public override bool Guardar()
        {
            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Notas (EstudianteId, MateriaId, Nota) VALUES (@EstudianteId, @MateriaId, @Nota)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EstudianteId", EstudianteId);
                    cmd.Parameters.AddWithValue("@MateriaId", MateriaId);
                    cmd.Parameters.AddWithValue("@Nota", Nota);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la nota: " + ex.Message);
                return false;
            }
        }
    }

}
