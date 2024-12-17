using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinalcruds
{
    public partial class Diagnósticos : Form
    {
        public Diagnósticos()
        {
            InitializeComponent();
        }

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            Menu menuPrincipal = new Menu();

            // Mostrar el nuevo formulario
            menuPrincipal.Show();

            // Ocultar el formulario actual
            this.Hide();
        }
    }
}
