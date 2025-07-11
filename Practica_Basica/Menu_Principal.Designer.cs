namespace Capa_Presentacion
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            btnAgregarEstudiantes = new Button();
            btnGestionNotas = new Button();
            btnReporteAcademico = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarEstudiantes
            // 
            btnAgregarEstudiantes.BackColor = SystemColors.MenuHighlight;
            btnAgregarEstudiantes.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregarEstudiantes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarEstudiantes.ForeColor = SystemColors.HighlightText;
            btnAgregarEstudiantes.Location = new Point(12, 12);
            btnAgregarEstudiantes.Name = "btnAgregarEstudiantes";
            btnAgregarEstudiantes.RightToLeft = RightToLeft.No;
            btnAgregarEstudiantes.Size = new Size(117, 72);
            btnAgregarEstudiantes.TabIndex = 0;
            btnAgregarEstudiantes.Text = "Agregar Estudiantes";
            btnAgregarEstudiantes.UseVisualStyleBackColor = false;
            btnAgregarEstudiantes.Click += btnAgregarEstudiantes_Click;
            // 
            // btnGestionNotas
            // 
            btnGestionNotas.BackColor = SystemColors.MenuHighlight;
            btnGestionNotas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionNotas.ForeColor = SystemColors.HighlightText;
            btnGestionNotas.Location = new Point(12, 106);
            btnGestionNotas.Name = "btnGestionNotas";
            btnGestionNotas.Size = new Size(117, 73);
            btnGestionNotas.TabIndex = 1;
            btnGestionNotas.Text = "Gestion de Notas";
            btnGestionNotas.UseVisualStyleBackColor = false;
            btnGestionNotas.Click += btnGestionNotas_Click;
            // 
            // btnReporteAcademico
            // 
            btnReporteAcademico.BackColor = SystemColors.MenuHighlight;
            btnReporteAcademico.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporteAcademico.ForeColor = SystemColors.HighlightText;
            btnReporteAcademico.Location = new Point(12, 202);
            btnReporteAcademico.Name = "btnReporteAcademico";
            btnReporteAcademico.Size = new Size(117, 75);
            btnReporteAcademico.TabIndex = 2;
            btnReporteAcademico.Text = "Reporte Academico";
            btnReporteAcademico.UseVisualStyleBackColor = false;
            btnReporteAcademico.Click += btnReporteAcademico_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.MenuHighlight;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.HighlightText;
            btnSalir.Location = new Point(12, 303);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(117, 73);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(568, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Menu_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 388);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnReporteAcademico);
            Controls.Add(btnGestionNotas);
            Controls.Add(btnAgregarEstudiantes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu_Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarEstudiantes;
        private Button btnGestionNotas;
        private Button btnReporteAcademico;
        private Button btnSalir;
        private PictureBox pictureBox1;
    }
}