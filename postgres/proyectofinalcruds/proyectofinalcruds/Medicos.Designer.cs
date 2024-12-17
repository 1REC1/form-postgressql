namespace proyectofinalcruds
{
    partial class Medicos
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
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            dgvMedicos = new DataGridView();
            txtTelefono = new TextBox();
            txtApellidos = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombres = new TextBox();
            txtEspecialidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).BeginInit();
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
            // btnEliminar
            // 
            btnEliminar.Location = new Point(46, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 56);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(46, 244);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(104, 56);
            btnActualizar.TabIndex = 35;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(46, 154);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(104, 56);
            btnInsertar.TabIndex = 34;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // dgvMedicos
            // 
            dgvMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicos.Location = new Point(225, 154);
            dgvMedicos.Name = "dgvMedicos";
            dgvMedicos.Size = new Size(529, 229);
            dgvMedicos.TabIndex = 33;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(693, 77);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(120, 23);
            txtTelefono.TabIndex = 31;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(308, 77);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(183, 23);
            txtApellidos.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(727, 59);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 29;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 59);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 28;
            label3.Text = "Especialidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 59);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 27;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 59);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 26;
            label1.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(46, 77);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(206, 23);
            txtNombres.TabIndex = 25;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(527, 77);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(137, 23);
            txtEspecialidad.TabIndex = 37;
            // 
            // Medicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(txtEspecialidad);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(dgvMedicos);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombres);
            Controls.Add(btnRegreso);
            Name = "Medicos";
            Text = "Medicos";
            ((System.ComponentModel.ISupportInitialize)dgvMedicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegreso;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridView dgvMedicos;
        private TextBox txtTelefono;
        private TextBox txtApellidos;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombres;
        private TextBox txtEspecialidad;
    }
}