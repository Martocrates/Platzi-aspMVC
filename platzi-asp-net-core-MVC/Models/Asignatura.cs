using System;
using System.Collections.Generic;

namespace platzi_asp_net_core_MVC.Models
{
    public class Asignatura : ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        public Curso Curso { get; set; }

        public List<Evaluacion> Evaluaciones { get; set; }
    }
}