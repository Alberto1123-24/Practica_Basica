using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            if (ValidarCredenciales(usuario, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso");

                // Abrir el menú principal
                Menu_Principal menu = new Menu_Principal();
                menu.Show();

                // Ocultar el formulario de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }

        private bool ValidarCredenciales(string usuario, string contrasena)
        {
            bool resultado = false;
            ConexionDatos conexion = new ConexionDatos();

            using (SqlConnection con = conexion.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE Usuario = @usuario AND Contrasena = @contrasena";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                resultado = count > 0;
            }

            return resultado;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
