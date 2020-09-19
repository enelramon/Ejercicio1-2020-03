using System.ComponentModel.DataAnnotations;

public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage ="Es obligatorio introducir el nombre")]
        public string Nombres { get; set; }

        [Range(minimum:1, maximum:10,ErrorMessage ="Seleccione un semestre")]
        public int Semestre { get; set; }


    

       

    }
