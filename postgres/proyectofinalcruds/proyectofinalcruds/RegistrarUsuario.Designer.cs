namespace proyectofinalcruds
{
    partial class RegistrarUsuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtRol = new TextBox();
            txtContrasena = new TextBox();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnRegreso
            // 
            btnRegreso.Location = new Point(12, 12);
            btnRegreso.Name = "btnRegreso";
            btnRegreso.Size = new Size(78, 37);
            btnRegreso.TabIndex = 0;
            btnRegreso.Text = "Regreso";
            btnRegreso.UseVisualStyleBackColor = true;
            btnRegreso.Click += btnRegreso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 61);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "Rol";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(525, 61);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(249, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(388, 79);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(100, 23);
            txtRol.TabIndex = 5;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(506, 79);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(31, 130);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 56);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Insertar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(31, 220);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(104, 56);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(31, 312);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 56);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(182, 142);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(509, 248);
            dgvUsuarios.TabIndex = 10;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 552);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtContrasena);
            Controls.Add(txtRol);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegreso);
            Name = "RegistrarUsuario";
            Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegreso;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtRol;
        private TextBox txtContrasena;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;
        private DataGridView dgvUsuarios;
    }
}