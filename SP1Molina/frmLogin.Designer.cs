namespace SP1Molina
{
    partial class frmLogin
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblMódulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lstMódulo = new ComboBox();
            button1 = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(45, 49);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.ForeColor = Color.Black;
            lblContraseña.Location = new Point(45, 122);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(67, 15);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblMódulo
            // 
            lblMódulo.AutoSize = true;
            lblMódulo.ForeColor = Color.Black;
            lblMódulo.Location = new Point(45, 196);
            lblMódulo.Name = "lblMódulo";
            lblMódulo.Size = new Size(49, 15);
            lblMódulo.TabIndex = 2;
            lblMódulo.Text = "Módulo";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.Navy;
            txtUsuario.Location = new Point(178, 41);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(155, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.ForeColor = Color.Navy;
            txtContraseña.Location = new Point(178, 114);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(155, 23);
            txtContraseña.TabIndex = 4;
            // 
            // lstMódulo
            // 
            lstMódulo.DropDownStyle = ComboBoxStyle.DropDownList;
            lstMódulo.FormattingEnabled = true;
            lstMódulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            lstMódulo.Location = new Point(178, 188);
            lstMódulo.Name = "lstMódulo";
            lstMódulo.Size = new Size(155, 23);
            lstMódulo.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(395, 43);
            button1.Name = "button1";
            button1.Size = new Size(77, 21);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 114);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 21);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 278);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(lstMódulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblMódulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblMódulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox lstMódulo;
        private Button button1;
        private Button btnCancelar;
    }
}