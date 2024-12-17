using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectofinalcruds
{
    public partial class Form1 : Form
    {
        // Cadena de conexión a la base de datos (ajusta tu servidor y base de datos)
        private string connectionString = "Server=FATY; Database=ClinicaDB; Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void lblRegistrarse_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de registro
            RegistrarUsuario usuario = new RegistrarUsuario();

            // Mostrar el formulario de registro
            usuario.Show();

            // Ocultar el formulario de login
            this.Hide();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;  // Asumiendo que el TextBox para el usuario se llama txtUsuario
            string contrasena = txtPassword.Text;  // Asumiendo que el TextBox para la contraseña se llama txtPassword

            if (ValidarLogin(usuario, contrasena))
            {
                // Si el login es exitoso, muestra el formulario principal (Menu)
                Menu menuPrincipal = new Menu();
                menuPrincipal.Show();

                // Ocultar el formulario de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        // Método para validar el login en la base de datos
        private bool ValidarLogin(string usuario, string contrasena)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para verificar el usuario y la contraseña (sin cifrado)
                    string query = "SELECT COUNT(*) FROM usuarios WHERE Nombre = @usuario AND Contrasena = @contrasena";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contrasena);  // Ahora pasamos la contraseña tal como está

                    int count = (int)command.ExecuteScalar();  // Devuelve el número de registros que coinciden

                    return count > 0;  // Si es mayor a 0, el login es válido
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
