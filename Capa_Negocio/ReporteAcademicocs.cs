using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{

    public class ReporteAcademico : BaseReporte
    {
        public double Promedio { get; set; }
        public int MateriasInscritas { get; set; }

        public ReporteAcademico(string estudiante, double promedio, int materias)
        : base(estudiante)
        {
            Promedio = promedio;
            MateriasInscritas = materias;
        }

        public override string GenerarResumen()
        {
            return $"Estudiante: {Estudiante}\nPromedio: {Promedio}\nMaterias: {MateriasInscritas}";
        }
    }

}
