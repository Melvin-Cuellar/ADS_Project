using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Materia
    {
        //Al atributo Id no es necesario ponerle requerimientos porque se obtiene automaticamente
        //del gestor de la base de datos al ingresar un registro ya que se estableció como autoincrementable
        public int IdMateria { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        [MaxLength(length: 50, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string NombreMateria { get; set; }
    }
}
