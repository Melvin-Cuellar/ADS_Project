using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdEstudiante))]
    public class Estudiante
    {
        //Al atributo Id no es necesario ponerle requerimientos porque se obtiene automaticamente
        //del gestor de la base de datos al ingresar un registro ya que se estableció como autoincrementable
        public int IdEstudiante { get; set; }

        [Required(ErrorMessage="Éste es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombresEstudiante { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string ApellidosEstudiante { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        [MinLength(length: 12, ErrorMessage = "La longitud del campo no puede ser menor a 12 caracteres.")]
        [MaxLength(length: 12, ErrorMessage = "La longitud del campo no puede ser mayor a 12 caracteres.")]
        public string CodigoEstudiante { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser mayor a 254 caracteres.")]
        [EmailAddress(ErrorMessage = "El formato de correo electronico no es correcto.")]
        public string CorreoEstudiante { get; set; }
    }
}
