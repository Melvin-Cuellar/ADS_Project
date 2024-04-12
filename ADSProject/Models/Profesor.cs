using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Profesor
    {
        //Al atributo Id no es necesario ponerle requerimientos porque se obtiene automaticamente
        //del gestor de la base de datos al ingresar un registro ya que se estableció como autoincrementable
        public int IdProfesor { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombresProfesor { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string ApellidosProfesor { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        [MaxLength(length: 254, ErrorMessage = "La longitud del campo no puede ser mayor a 254 caracteres.")]
        [EmailAddress(ErrorMessage = "El formato de correo electronico no es correcto.")]
        public string Email { get; set; }
    }
}
