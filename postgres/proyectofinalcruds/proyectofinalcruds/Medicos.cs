using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectofinalcruds
{
    public partial class Medicos : Form
    {
        public string conexionBD = @"Server=FATY;Database=ClinicaDB;Integrated Security=True";

        public Medicos()
        {
            InitializeComponent();
            LoadMedicos();
        }

        // Método para cargar los médicos en el DataGridView
        private void LoadMedicos()
        {
            using (SqlConnection connection = new SqlConnection(conexionBD))
            {
                string query = "SELECT Id, Nombre, Apellido, Especialidad, Telefono, Estado FROM medicos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvMedicos.DataSource = dataTable;
            }
        }

        // Botón para regresar al menú principal
        private void btnRegreso_Click(object sender, EventArgs e)
        {
            Menu menuPrincipal = new Menu();
            menuPrincipal.Show();
            this.Hide();
        }

        // Botón para insertar un nuevo médico
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string especialidad = txtEspecialidad.Text;
            string telefono = txtTelefono.Text;

            using (SqlConnection connection = new SqlConnection(conexionBD))
            {
                string query = "INSERT INTO medicos (Nombre, Apellido, Especialidad, Telefono, Fecha_Creacion, Estado) " +
                               "VALUES (@Nombre, @Apellido, @Especialidad, @Telefono, GETDATE(), 'Activo')";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Especialidad", especialidad);
                command.Parameters.AddWithValue("@Telefono", telefono);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            // Recargar el DataGridView después de insertar
            LoadMedicos();

            // Limpiar los campos de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEspecialidad.Clear();
            txtTelefono.Clear();
        }

        // Botón para actualizar los datos de un médico seleccionado
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedicos.SelectedRows[0].Cells["Id"].Value);
                string nombre = txtNombres.Text;
                string apellido = txtApellidos.Text;
                string especialidad = txtEspecialidad.Text;
                string telefono = txtTelefono.Text;

                using (SqlConnection connection = new SqlConnection(conexionBD))
                {
                    string query = "UPDATE medicos SET Nombre = @Nombre, Apellido = @Apellido, Especialidad = @Especialidad, " +
                                   "Telefono = @Telefono, Fecha_Modificacion = GETDATE() WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Especialidad", especialidad);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                // Recargar el DataGridView después de actualizar
                LoadMedicos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un médico para actualizar.");
            }
        }

        // Botón para eliminar un médico seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedicos.SelectedRows[0].Cells["Id"].Value);

                using (SqlConnection connection = new SqlConnection(conexionBD))
                {
                    string query = "DELETE FROM medicos WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                // Recargar el DataGridView después de eliminar
                LoadMedicos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un médico para eliminar.");
            }
        }

        // Evento de selección de fila en el DataGridView para mostrar los datos en los campos de texto
        private void dgvMedicos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMedicos.SelectedRows.Count > 0)
            {
                // Obtener los valores de la fila seleccionada
                txtNombres.Text = dgvMedicos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                txtApellidos.Text = dgvMedicos.SelectedRows[0].Cells["Apellido"].Value.ToString();
                txtEspecialidad.Text = dgvMedicos.SelectedRows[0].Cells["Especialidad"].Value.ToString();
                txtTelefono.Text = dgvMedicos.SelectedRows[0].Cells["Telefono"].Value.ToString();
            }
        }
    }
}
