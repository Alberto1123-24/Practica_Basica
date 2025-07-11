using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Reporte_Academico : Form
    {
        public Reporte_Academico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            string estudiante = txtEstudiante.Text.Trim();
            if (string.IsNullOrEmpty(estudiante)) return;

            HistorialAcademico historial = new HistorialAcademico();

            // Mostrar historial en el DataGridView
            dgvHistorial.DataSource = historial.ObtenerHistorial(estudiante);

            // Mostrar resumen
            var resumen = historial.ObtenerResumen(estudiante);
            lblpromedio2.Text = resumen.promedio.ToString("0.00");
            lblmaterias2.Text = resumen.cantidad.ToString();


        }

        private void lblpromedio2_Click(object sender, EventArgs e)
        {

        }

        private void txtEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}

