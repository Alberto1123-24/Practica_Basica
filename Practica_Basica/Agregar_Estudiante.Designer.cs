﻿namespace Practica_Basica
{
    partial class Agregarestudiante
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregarestudiante));
            lblTitulo = new Label();
            lblNombre = new Label();
            lblEdad = new Label();
            lblDocumento = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtDocumento = new TextBox();
            btnAgregar = new Button();
            lblLista = new Label();
            lblBuscarID = new Label();
            lblBuscarporID = new Label();
            txtBuscarID = new TextBox();
            btnBuscar = new Button();
            dataGridViewEstudiantes = new DataGridView();
            txtPasaporte = new TextBox();
            lblPasaporte = new Label();
            cmbFiltroDocumento = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Estudiante ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F);
            lblNombre.Location = new Point(12, 54);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 10F);
            lblEdad.Location = new Point(12, 94);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(48, 23);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 10F);
            lblDocumento.Location = new Point(12, 134);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(63, 23);
            lblDocumento.TabIndex = 3;
            lblDocumento.Text = "Cedula";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(234, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(150, 93);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 2;
            txtEdad.KeyPress += txtEdad_KeyPress;
            txtEdad.Validating += txtEdad_Validating;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(150, 134);
            txtDocumento.MaxLength = 11;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.ShortcutsEnabled = false;
            txtDocumento.Size = new Size(234, 27);
            txtDocumento.TabIndex = 3;
            txtDocumento.KeyPress += txtDocumento_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.MenuHighlight;
            btnAgregar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.HighlightText;
            btnAgregar.Location = new Point(457, 54);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 53);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLista.Location = new Point(13, 224);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(168, 23);
            lblLista.TabIndex = 8;
            lblLista.Text = "Lista de Estudiantes";
            lblLista.Click += lblLista_Click;
            // 
            // lblBuscarID
            // 
            lblBuscarID.AutoSize = true;
            lblBuscarID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarID.Location = new Point(12, 481);
            lblBuscarID.Name = "lblBuscarID";
            lblBuscarID.Size = new Size(118, 23);
            lblBuscarID.TabIndex = 10;
            lblBuscarID.Text = "Buscar por ID";
            // 
            // lblBuscarporID
            // 
            lblBuscarporID.AutoSize = true;
            lblBuscarporID.Font = new Font("Segoe UI", 10F);
            lblBuscarporID.Location = new Point(48, 518);
            lblBuscarporID.Name = "lblBuscarporID";
            lblBuscarporID.Size = new Size(27, 23);
            lblBuscarporID.TabIndex = 11;
            lblBuscarporID.Text = "ID";
            lblBuscarporID.Click += lblBuscarporID_Click;
            // 
            // txtBuscarID
            // 
            txtBuscarID.Location = new Point(150, 518);
            txtBuscarID.Name = "txtBuscarID";
            txtBuscarID.Size = new Size(234, 27);
            txtBuscarID.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.MenuHighlight;
            btnBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.HighlightText;
            btnBuscar.Location = new Point(421, 505);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(144, 50);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dataGridViewEstudiantes
            // 
            dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstudiantes.Location = new Point(13, 261);
            dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            dataGridViewEstudiantes.ReadOnly = true;
            dataGridViewEstudiantes.RowHeadersWidth = 51;
            dataGridViewEstudiantes.Size = new Size(687, 207);
            dataGridViewEstudiantes.TabIndex = 14;
            dataGridViewEstudiantes.CellContentClick += dataGridViewEstudiantes_CellContentClick;
            // 
            // txtPasaporte
            // 
            txtPasaporte.Location = new Point(150, 176);
            txtPasaporte.Name = "txtPasaporte";
            txtPasaporte.Size = new Size(234, 27);
            txtPasaporte.TabIndex = 4;
            // 
            // lblPasaporte
            // 
            lblPasaporte.AutoSize = true;
            lblPasaporte.Font = new Font("Segoe UI", 10F);
            lblPasaporte.Location = new Point(13, 176);
            lblPasaporte.Name = "lblPasaporte";
            lblPasaporte.Size = new Size(85, 23);
            lblPasaporte.TabIndex = 16;
            lblPasaporte.Text = "Pasaporte";
            // 
            // cmbFiltroDocumento
            // 
            cmbFiltroDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroDocumento.FormattingEnabled = true;
            cmbFiltroDocumento.Location = new Point(518, 207);
            cmbFiltroDocumento.Name = "cmbFiltroDocumento";
            cmbFiltroDocumento.Size = new Size(151, 28);
            cmbFiltroDocumento.TabIndex = 17;
            cmbFiltroDocumento.SelectedIndexChanged += cmbFiltroDocumento_SelectedIndexChanged_1;
            cmbFiltroDocumento.KeyPress += cmbFiltroDocumento_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 200;
            errorProvider1.ContainerControl = this;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.MenuHighlight;
            btnEliminar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.HighlightText;
            btnEliminar.Location = new Point(457, 134);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 48);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += button1_Click;
            // 
            // Agregarestudiante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(711, 599);
            Controls.Add(btnEliminar);
            Controls.Add(cmbFiltroDocumento);
            Controls.Add(lblPasaporte);
            Controls.Add(txtPasaporte);
            Controls.Add(dataGridViewEstudiantes);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarID);
            Controls.Add(lblBuscarporID);
            Controls.Add(lblBuscarID);
            Controls.Add(lblLista);
            Controls.Add(btnAgregar);
            Controls.Add(txtDocumento);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblDocumento);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Agregarestudiante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Estudiantes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstudiantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblEdad;
        private Label lblDocumento;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtDocumento;
        private Button btnAgregar;
        private Label lblLista;
        private Label lblBuscarID;
        private Label lblBuscarporID;
        private TextBox txtBuscarID;
        private Button btnBuscar;
        private DataGridView dataGridViewEstudiantes;
        private TextBox txtPasaporte;
        private Label lblPasaporte;
        private ComboBox cmbFiltroDocumento;
        private ErrorProvider errorProvider1;
        private Button btnEliminar;
    }
}
