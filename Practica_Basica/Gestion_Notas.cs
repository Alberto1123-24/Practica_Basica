using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Presentacion
{

    public partial class Gestion_Notas : Form
    {
        private SqlConnection conexion;

        public object CadenaConexion { get; private set; }

        public Gestion_Notas()
        {
            InitializeComponent();
            conexion = new SqlConnection("Server=.; Database=Practica_Basica1; Integrated Security=true; TrustServerCertificate=True"); // Inicializar la conexión con una cadena de conexión válida
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CargarNotas(int estudianteId)
        {
        }

        private void Gestion_Notas_Load(object sender, EventArgs e)
        {
            EstudianteNegocio negocio = new EstudianteNegocio();
            List<string> estudiantes = negocio.ObtenerNombresEstudiantes();

            comboBoxEstudiante.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxEstudiante.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxEstudiante.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxEstudiante.Items.AddRange(estudiantes.ToArray());

            MateriaNegocio negocio1 = new MateriaNegocio();
            List<MateriaNegocio.Materia> materias = negocio.ObtenerMaterias();

            cmbMateria.DataSource = materias;
            cmbMateria.DisplayMember = "Nombre";
            cmbMateria.ValueMember = "Id";

            CargarNotas();
        }

        private void txtEstudiante_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            if (comboBoxEstudiante.SelectedItem == null || cmbMateria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estudiante y una materia.");
                return;
            }

            int estudianteId = ObtenerIdEstudiantePorNombre(comboBoxEstudiante.Text); 

            if (cmbMateria.SelectedValue == null)
            {
                MessageBox.Show("La materia seleccionada no es válida.");
                return;
            }

            int materiaId = (int)cmbMateria.SelectedValue; 
            decimal nota = nudNota.Value;

            NotaFinal notaFinal = new NotaFinal(estudianteId, materiaId, nota);
            if (notaFinal.Guardar())
            {
                MessageBox.Show("Nota guardada correctamente.");

            }
            CargarNotas();
        }

        private int ObtenerIdEstudiantePorNombre(string nombre)
        {
            try
            {
                // Reemplazar "CadenaConexion.ObtenerConexion()" con la cadena de conexión directamente
                using (SqlConnection conn = new SqlConnection(conexion.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Id FROM Estudiante WHERE Nombre = @Nombre";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Estudiante no encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el ID del estudiante: " + ex.Message);
            }
        }


        private void CargarNotas()
        {
            NotaNegocio notaNegocio = new NotaNegocio();
            dgvMateriasynotas.DataSource = notaNegocio.ObtenerNotas();
        }

    }
}
