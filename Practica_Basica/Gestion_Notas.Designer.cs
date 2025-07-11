namespace Capa_Presentacion
{
    partial class Gestion_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Notas));
            lblEstudiante = new Label();
            lblGestionNotas = new Label();
            label1 = new Label();
            lblNota = new Label();
            cmbMateria = new ComboBox();
            nudNota = new NumericUpDown();
            dgvMateriasynotas = new DataGridView();
            lblMaterias_Y_Notas = new Label();
            btnGuardarNota = new Button();
            comboBoxEstudiante = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasynotas).BeginInit();
            SuspendLayout();
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Segoe UI", 10F);
            lblEstudiante.Location = new Point(12, 50);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(90, 23);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante";
            lblEstudiante.Click += label1_Click;
            // 
            // lblGestionNotas
            // 
            lblGestionNotas.AutoSize = true;
            lblGestionNotas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionNotas.Location = new Point(12, 9);
            lblGestionNotas.Name = "lblGestionNotas";
            lblGestionNotas.Size = new Size(146, 23);
            lblGestionNotas.TabIndex = 1;
            lblGestionNotas.Text = "Gestion de Notas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(68, 23);
            label1.TabIndex = 2;
            label1.Text = "Materia";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Font = new Font("Segoe UI", 10F);
            lblNota.Location = new Point(12, 132);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(48, 23);
            lblNota.TabIndex = 3;
            lblNota.Text = "Nota";
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(164, 90);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(151, 28);
            cmbMateria.TabIndex = 6;
            // 
            // nudNota
            // 
            nudNota.Location = new Point(165, 132);
            nudNota.Name = "nudNota";
            nudNota.Size = new Size(150, 27);
            nudNota.TabIndex = 7;
            // 
            // dgvMateriasynotas
            // 
            dgvMateriasynotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriasynotas.Location = new Point(15, 238);
            dgvMateriasynotas.Name = "dgvMateriasynotas";
            dgvMateriasynotas.RowHeadersWidth = 51;
            dgvMateriasynotas.Size = new Size(393, 188);
            dgvMateriasynotas.TabIndex = 8;
            // 
            // lblMaterias_Y_Notas
            // 
            lblMaterias_Y_Notas.AutoSize = true;
            lblMaterias_Y_Notas.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaterias_Y_Notas.Location = new Point(12, 201);
            lblMaterias_Y_Notas.Name = "lblMaterias_Y_Notas";
            lblMaterias_Y_Notas.Size = new Size(230, 23);
            lblMaterias_Y_Notas.TabIndex = 9;
            lblMaterias_Y_Notas.Text = "Materias y Notas Asignadas";
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.BackColor = SystemColors.MenuHighlight;
            btnGuardarNota.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarNota.ForeColor = SystemColors.HighlightText;
            btnGuardarNota.Location = new Point(142, 461);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(133, 46);
            btnGuardarNota.TabIndex = 10;
            btnGuardarNota.Text = "Guardar Nota";
            btnGuardarNota.UseVisualStyleBackColor = false;
            btnGuardarNota.Click += btnGuardarNota_Click;
            // 
            // comboBoxEstudiante
            // 
            comboBoxEstudiante.FormattingEnabled = true;
            comboBoxEstudiante.Location = new Point(164, 45);
            comboBoxEstudiante.Name = "comboBoxEstudiante";
            comboBoxEstudiante.Size = new Size(244, 28);
            comboBoxEstudiante.TabIndex = 11;
            // 
            // Gestion_Notas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 540);
            Controls.Add(comboBoxEstudiante);
            Controls.Add(btnGuardarNota);
            Controls.Add(lblMaterias_Y_Notas);
            Controls.Add(dgvMateriasynotas);
            Controls.Add(nudNota);
            Controls.Add(cmbMateria);
            Controls.Add(lblNota);
            Controls.Add(label1);
            Controls.Add(lblGestionNotas);
            Controls.Add(lblEstudiante);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Gestion_Notas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Notas";
            Load += Gestion_Notas_Load;
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMateriasynotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstudiante;
        private Label lblGestionNotas;
        private Label label1;
        private Label lblNota;
        private ComboBox cmbMateria;
        private NumericUpDown nudNota;
        private DataGridView dgvMateriasynotas;
        private Label lblMaterias_Y_Notas;
        private Button btnGuardarNota;
        private ComboBox comboBoxEstudiante;
    }
}