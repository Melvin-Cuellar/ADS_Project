using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Carrera
    {
        //Al atributo Id no es necesario ponerle requerimientos porque se obtiene automaticamente
        //del gestor de la base de datos al ingresar un registro ya que se estableció como autoincrementable
        public int Id { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede ser mayor a 3 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser mayor a 40 caracteres.")]
        public string Nombre { get; set; }
    }
}
