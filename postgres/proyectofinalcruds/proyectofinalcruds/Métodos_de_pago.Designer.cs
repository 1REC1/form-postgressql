namespace proyectofinalcruds
{
    partial class Métodos_de_pago
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
            SuspendLayout();
            // 
            // btnRegreso
            // 
            btnRegreso.Location = new Point(12, 21);
            btnRegreso.Name = "btnRegreso";
            btnRegreso.Size = new Size(78, 37);
            btnRegreso.TabIndex = 11;
            btnRegreso.Text = "Regreso";
            btnRegreso.UseVisualStyleBackColor = true;
            btnRegreso.Click += btnRegreso_Click;
            // 
            // Métodos_de_pago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegreso);
            Name = "Métodos_de_pago";
            Text = "Métodos_de_pago";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegreso;
    }
}