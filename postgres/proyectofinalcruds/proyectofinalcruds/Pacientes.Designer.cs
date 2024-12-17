namespace proyectofinalcruds
{
    partial class Pacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegreso = new Button();
            txtNombres = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtApellidos = new TextBox();
            cmbxSexo = new ComboBox();
            txtEdad = new TextBox();
            dgvPacientes = new DataGridView();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // btnRegreso
            // 
            btnRegreso.Location = new Point(12, 12);
            btnRegreso.Name = "btnRegreso";
            btnRegreso.Size = new Size(78, 37);
            btnRegreso.TabIndex = 11;
            btnRegreso.Text = "Regreso";
            btnRegreso.UseVisualStyleBackColor = true;
            btnRegreso.Click += btnRegreso_Click;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(44, 115);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(206, 23);
            txtNombres.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 97);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 97);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 14;
            label2.Text = "Apellidos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 97);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 15;
            label3.Text = "Sexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(674, 97);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 16;
            label4.Text = "Edad";
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(306, 115);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(183, 23);
            txtApellidos.TabIndex = 20;
            // 
            // cmbxSexo
            // 
            cmbxSexo.FormattingEnabled = true;
            cmbxSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbxSexo.Location = new Point(508, 115);
            cmbxSexo.Name = "cmbxSexo";
            cmbxSexo.Size = new Size(117, 23);
            cmbxSexo.TabIndex = 18;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(654, 115);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(65, 23);
            txtEdad.TabIndex = 19;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(223, 192);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(529, 229);
            dgvPacientes.TabIndex = 21;
            dgvPacientes.CellContentClick += dgvPacientes_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(44, 374);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 56);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(44, 282);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(104, 56);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(44, 192);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(104, 56);
            btnInsertar.TabIndex = 22;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // Pacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvPacientes);
            Controls.Add(txtEdad);
            Controls.Add(cmbxSexo);
            Controls.Add(txtApellidos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Controls.Add(btnRegreso);
            Name = "Pacientes";
            Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegreso;
        private TextBox txtNombres;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtApellidos;
        private ComboBox cmbxSexo;
        private TextBox txtEdad;
        private DataGridView dgvPacientes;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnInsertar;
    }
}