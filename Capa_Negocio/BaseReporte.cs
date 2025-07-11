using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{

    public abstract class BaseReporte
    {
        public string Estudiante { get; set; }

        public BaseReporte(string estudiante)
        {
            Estudiante = estudiante;
        }

        public virtual string GenerarResumen()
        {
            return $"Resumen académico de {Estudiante}";
        }
    }

}
