namespace Capa_Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblComentario = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(176, 97);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(227, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(176, 144);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(227, 27);
            txtContraseña.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = SystemColors.MenuHighlight;
            btnAcceder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = SystemColors.ButtonHighlight;
            btnAcceder.Location = new Point(176, 190);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(110, 46);
            btnAcceder.TabIndex = 2;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(59, 101);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(59, 145);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(99, 23);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Font = new Font("Segoe UI", 6F);
            lblComentario.Location = new Point(18, 263);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(175, 12);
            lblComentario.TabIndex = 5;
            lblComentario.Text = "© 2025 Todos los derechos reservados.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(164, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 290);
            Controls.Add(pictureBox1);
            Controls.Add(lblComentario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnAcceder;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblComentario;
        private PictureBox pictureBox1;
    }
}