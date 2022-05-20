using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platzi_asp_net_core_MVC.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        [Display(Prompt = "Nombre del curso", Name = "Nombre")]
        [Required(ErrorMessage ="Debe escribir un nombre de curso")]
        public override string Nombre { set; get; }
        [Display(Prompt = "Jornada", Name = "Nombre")]
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        [Display(Prompt = "Direccion", Name = "Address")]
        [Required(ErrorMessage = "Debe escribir una direccion")]
        [MinLength(10,ErrorMessage ="La direccion no debe ser tan corta")]
        public string Direccion { get; set; }

        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }

    }
}