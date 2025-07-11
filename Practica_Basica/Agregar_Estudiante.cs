using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
using Capa_Negocio;
using Microsoft.Data.SqlClient;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;

namespace Practica_Basica
{
    public partial class Agregarestudiante : Form
    {
        public class EstudianteNacional : Estudiante
        {

        }

        public class EstudianteExtranjero : Estudiante
        {

        }

        private ConexionDatos conexion;
        private EventHandler cmbFiltroDocumento_SelectedIndexChanged;

        public Agregarestudiante()
        {
            InitializeComponent();
            DatosEnGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFiltroDocumento.Items.AddRange(new string[] { "Todos", "Cédula", "Pasaporte" });
            cmbFiltroDocumento.SelectedIndex = 0;
            cmbFiltroDocumento.SelectedIndexChanged += CmbFiltroDocumento_SelectedIndexChanged;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios (Nombre y Edad).", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que solo uno de los dos (Cédula o Pasaporte) esté lleno
            bool cedulaLlena = !string.IsNullOrWhiteSpace(txtDocumento.Text);
            bool pasaporteLleno = !string.IsNullOrWhiteSpace(txtPasaporte.Text);

            if (!cedulaLlena && !pasaporteLleno)
            {
                MessageBox.Show("Debe ingresar Cédula o Pasaporte.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cedulaLlena && pasaporteLleno)
            {
                MessageBox.Show("Solo puede ingresar Cédula o Pasaporte, no ambos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text))
            //string.IsNullOrWhiteSpace(txtDocumento.Text))

            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string.IsNullOrEmpty(txtPasaporte.Text);

            // Confirmamos que Edad sea un número entero
            if (!int.TryParse(txtEdad.Text.Trim(), out int edad))
            {
                MessageBox.Show("La edad debe ser un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Crear instancia a la clase Estudiante 
                Estudiante estudiante = new Estudiante
                {
                    Nombre = txtNombre.Text.Trim(),
                    Edad = edad,
                    Cedula = txtDocumento.Text.Trim(),
                    Pasaporte = txtPasaporte.Text.Trim()
                };

                // Conexión a datos 
                ConexionDatos conexion = new ConexionDatos();
                conexion.Open();

                // Consulta SQL 
                string consulta = "INSERT INTO Estudiante (Nombre, Edad, Cedula, Pasaporte) VALUES (@Nombre, @Edad, @Documento, @Pasaporte)";
                SqlCommand comando = new SqlCommand(consulta, conexion.GetConnection());

                // Asignación de parámetros desde el objeto
                comando.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                comando.Parameters.AddWithValue("@Edad", estudiante.Edad);
                comando.Parameters.AddWithValue("@Documento", estudiante.Cedula);
                comando.Parameters.AddWithValue("@Pasaporte", estudiante.Pasaporte);
                comando.ExecuteNonQuery();

                MessageBox.Show("Datos agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia campos 
                txtNombre.Clear();
                txtEdad.Clear();
                txtDocumento.Clear();
                txtPasaporte.Clear();

                // Cargar datos en el datagrid
                DatosEnGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosEnGrid()
        {
            try
            {
                ConexionDatos conexion = new ConexionDatos();
                SqlConnection conn = conexion.GetConnection();
                conexion.Open();

                string query = "SELECT ID, Nombre, Edad, Cedula, Pasaporte FROM Estudiante";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dataGridViewEstudiantes.DataSource = tabla;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarID.Text) || !int.TryParse(txtBuscarID.Text, out int id))
            {
                MessageBox.Show("Ingrese un ID válido para buscar.", "ID Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ConexionDatos conexion = new ConexionDatos();
                conexion.Open();

                string consulta = "SELECT ID, Nombre, Edad, Cedula, Pasaporte FROM Estudiante WHERE ID = @ID";
                SqlCommand comando = new SqlCommand(consulta, conexion.GetConnection());
                comando.Parameters.AddWithValue("@ID", id);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Estudiante estudiante = new Estudiante
                    {
                        Id = lector.GetInt32(0),
                        Nombre = lector.GetString(1),
                        Edad = lector.GetInt32(2),
                        Cedula = lector.IsDBNull(3) ? "" : lector.GetString(3),
                        Pasaporte = lector.IsDBNull(4) ? "" : lector.GetString(4)
                    };

                    txtNombre.Text = estudiante.Nombre;
                    txtEdad.Text = estudiante.Edad.ToString();
                    txtDocumento.Text = estudiante.Cedula;
                    txtPasaporte.Text = estudiante.Pasaporte;

                    MessageBox.Show("Estudiante encontrado.", "Búsqueda exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ningún estudiante con ese ID.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lector.Close();
                conexion.Close();
                txtBuscarID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblBuscarporID_Click(object sender, EventArgs e) { }
        private void lblLista_Click(object sender, EventArgs e) { }
        private void dataGridViewEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbFiltroDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cmbFiltroDocumento.SelectedItem.ToString();

            try
            {
                ConexionDatos conexion = new ConexionDatos();
                SqlConnection conn = conexion.GetConnection();
                conexion.Open();

                string query = "SELECT ID, Nombre, Edad, Cedula, Pasaporte FROM Estudiante";

                if (filtro == "Cédula")
                {
                    query += " WHERE Cedula IS NOT NULL AND Cedula <> ''";
                }
                else if (filtro == "Pasaporte")
                {
                    query += " WHERE Pasaporte IS NOT NULL AND Pasaporte <> ''";
                }

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dataGridViewEstudiantes.DataSource = tabla;

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFiltroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(this.txtNombre, "No puede dejar este campo vacío");
            }
            else
            {
                errorProvider1.SetError(this.txtNombre, "");
            }


        }

        private void txtEdad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtEdad.Text == "")
            {
                errorProvider1.SetError(this.txtEdad, "No puede dejar este campo vacío");
            }
            else
            {
                errorProvider1.SetError(this.txtEdad, "");
            }

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
             "¿Estás seguro de que deseas eliminar los datos?",
             "Confirmar eliminación",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Warning
             );

            if (resultado == DialogResult.Yes)
            {
                // Eliminar de la base de datos
                string conexion = "Server=.; Database=Practica_Basica1; Integrated Security=true; TrustServerCertificate=True";
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Estudiante WHERE Cedula = @Cedula OR Pasaporte = @Pasaporte";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Cedula", txtDocumento.Text);
                            cmd.Parameters.AddWithValue("@Pasaporte", txtPasaporte.Text);
                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Datos eliminados correctamente.");
                                DatosEnGrid();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún registro con esa cédula o pasaporte.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }

                // Limpiar los campos
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtDocumento.Text = "";
                txtPasaporte.Text = "";
                
                //Hola

            }
        }

        private void cmbFiltroDocumento_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}


