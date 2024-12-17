using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinalcruds
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Form1 login = new Form1();

            // Mostrar el nuevo formulario
            login.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Pacientes pacientes = new Pacientes();

            // Mostrar el nuevo formulario
            pacientes.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Medicos medicos = new Medicos();

            // Mostrar el nuevo formulario
            medicos.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Personal_de_apoyo personal_de_apoyo = new Personal_de_apoyo();

            // Mostrar el nuevo formulario
            personal_de_apoyo.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Métodos_de_pago métodos_de_pago = new Métodos_de_pago();

            // Mostrar el nuevo formulario
            métodos_de_pago.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Tratamientos tratamientos = new Tratamientos();

            // Mostrar el nuevo formulario
            tratamientos.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Medicamentos medicamentos = new Medicamentos();

            // Mostrar el nuevo formulario
            medicamentos.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Diagnósticos diagnósticos = new Diagnósticos();

            // Mostrar el nuevo formulario
            diagnósticos.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Exámenes_medicos exámenes_medicos = new Exámenes_medicos();

            // Mostrar el nuevo formulario
            exámenes_medicos.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Habitaciones habitaciones = new Habitaciones();

            // Mostrar el nuevo formulario
            habitaciones.Show();

            // Ocultar el formulario actual
            this.Hide();
        }
    }
}
