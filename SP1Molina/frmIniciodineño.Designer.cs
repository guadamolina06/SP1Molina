namespace SP1Molina
{
    partial class frmIniciodineño
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
            lblBienvenido = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenido.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblBienvenido.Location = new Point(105, 66);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(351, 47);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvedido al Sistema";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(224, 219);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 30);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmIniciodineño
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 341);
            Controls.Add(btnAceptar);
            Controls.Add(lblBienvenido);
            Name = "frmIniciodineño";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Button btnAceptar;
    }
}