using System.ComponentModel.DataAnnotations;

namespace Ejercicio1_2020_03.Models{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        public string Nombres { get; set; }

        [Range(minimum:1, maximum:10,ErrorMessage ="Seleccione un semestre")]
        public int Semestre { get; set; }
    }
}

