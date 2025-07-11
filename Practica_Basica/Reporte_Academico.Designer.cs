namespace Capa_Presentacion
{
    partial class Reporte_Academico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte_Academico));
            lblReporteAcademico = new Label();
            lblEstudianteReporte = new Label();
            lblPromedio = new Label();
            label1 = new Label();
            txtEstudiante = new TextBox();
            lblPromedio1 = new Label();
            lblMaterias = new Label();
            lblHistorialAcademico = new Label();
            dgvHistorial = new DataGridView();
            button1 = new Button();
            lblpromedio2 = new Label();
            lblmaterias2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // lblReporteAcademico
            // 
            lblReporteAcademico.AutoSize = true;
            lblReporteAcademico.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReporteAcademico.Location = new Point(12, 9);
            lblReporteAcademico.Name = "lblReporteAcademico";
            lblReporteAcademico.Size = new Size(167, 23);
            lblReporteAcademico.TabIndex = 0;
            lblReporteAcademico.Text = "Reporte Academico";
            // 
            // lblEstudianteReporte
            // 
            lblEstudianteReporte.AutoSize = true;
            lblEstudianteReporte.Font = new Font("Segoe UI", 10F);
            lblEstudianteReporte.Location = new Point(12, 50);
            lblEstudianteReporte.Name = "lblEstudianteReporte";
            lblEstudianteReporte.Size = new Size(90, 23);
            lblEstudianteReporte.TabIndex = 1;
            lblEstudianteReporte.Text = "Estudiante";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI", 10F);
            lblPromedio.Location = new Point(12, 91);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(148, 23);
            lblPromedio.TabIndex = 2;
            lblPromedio.Text = "Promedio General";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(141, 23);
            label1.TabIndex = 3;
            label1.Text = "Materias inscritas";
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(193, 46);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(228, 27);
            txtEstudiante.TabIndex = 5;
            txtEstudiante.KeyPress += txtEstudiante_KeyPress;
            // 
            // lblPromedio1
            // 
            lblPromedio1.AutoSize = true;
            lblPromedio1.Font = new Font("Segoe UI", 10F);
            lblPromedio1.Location = new Point(193, 93);
            lblPromedio1.Name = "lblPromedio1";
            lblPromedio1.Size = new Size(0, 23);
            lblPromedio1.TabIndex = 6;
            // 
            // lblMaterias
            // 
            lblMaterias.AutoSize = true;
            lblMaterias.Font = new Font("Segoe UI", 10F);
            lblMaterias.Location = new Point(193, 132);
            lblMaterias.Name = "lblMaterias";
            lblMaterias.Size = new Size(0, 23);
            lblMaterias.TabIndex = 7;
            // 
            // lblHistorialAcademico
            // 
            lblHistorialAcademico.AutoSize = true;
            lblHistorialAcademico.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistorialAcademico.Location = new Point(12, 196);
            lblHistorialAcademico.Name = "lblHistorialAcademico";
            lblHistorialAcademico.Size = new Size(171, 23);
            lblHistorialAcademico.TabIndex = 8;
            lblHistorialAcademico.Text = "Historial Academico";
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(12, 238);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(409, 188);
            dgvHistorial.TabIndex = 9;
            dgvHistorial.CellContentClick += dgvHistorial_CellContentClick;
            dgvHistorial.KeyPress += dgvHistorial_KeyPress;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(290, 168);
            button1.Name = "button1";
            button1.Size = new Size(102, 41);
            button1.TabIndex = 11;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblpromedio2
            // 
            lblpromedio2.AutoSize = true;
            lblpromedio2.Location = new Point(193, 95);
            lblpromedio2.Name = "lblpromedio2";
            lblpromedio2.Size = new Size(0, 20);
            lblpromedio2.TabIndex = 12;
            lblpromedio2.Click += lblpromedio2_Click;
            // 
            // lblmaterias2
            // 
            lblmaterias2.AutoSize = true;
            lblmaterias2.Location = new Point(193, 132);
            lblmaterias2.Name = "lblmaterias2";
            lblmaterias2.Size = new Size(0, 20);
            lblmaterias2.TabIndex = 13;
            // 
            // Reporte_Academico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 455);
            Controls.Add(lblmaterias2);
            Controls.Add(lblpromedio2);
            Controls.Add(button1);
            Controls.Add(dgvHistorial);
            Controls.Add(lblHistorialAcademico);
            Controls.Add(lblMaterias);
            Controls.Add(lblPromedio1);
            Controls.Add(txtEstudiante);
            Controls.Add(label1);
            Controls.Add(lblPromedio);
            Controls.Add(lblEstudianteReporte);
            Controls.Add(lblReporteAcademico);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Reporte_Academico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reporte_Academico";
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReporteAcademico;
        private Label lblEstudianteReporte;
        private Label lblPromedio;
        private Label label1;
        private TextBox txtEstudiante;
        private Label lblPromedio1;
        private Label lblMaterias;
        private Label lblHistorialAcademico;
        private DataGridView dgvHistorial;
        private Button button1;
        private Label lblpromedio2;
        private Label lblmaterias2;
    }
}