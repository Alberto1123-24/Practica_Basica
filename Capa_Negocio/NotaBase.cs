using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{

    public abstract class NotaBase
    {
        public int EstudianteId { get; set; }
        public int MateriaId { get; set; }
        public decimal Nota { get; set; }

        public NotaBase(int estudianteId, int materiaId, decimal nota)
        {
            EstudianteId = estudianteId;
            MateriaId = materiaId;
            Nota = nota;
        }

        public abstract bool Guardar();
    }
}


