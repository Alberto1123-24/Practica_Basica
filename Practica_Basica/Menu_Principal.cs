using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica_Basica;

namespace Capa_Presentacion
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btnAgregarEstudiantes_Click(object sender, EventArgs e)
        {
            Agregarestudiante Agregarestudiante = new Agregarestudiante();
            Agregarestudiante.ShowDialog();

        }

        private void btnGestionNotas_Click(object sender, EventArgs e)
        {
            Gestion_Notas Gestion_Notas = new Gestion_Notas();
            Gestion_Notas.ShowDialog();
        }

        private void btnReporteAcademico_Click(object sender, EventArgs e)
        {
            Reporte_Academico Reporte_Academico = new Reporte_Academico();
            Reporte_Academico.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
