using System.ComponentModel.DataAnnotations;

namespace ADSProject.Models
{
    public class Grupo
    {
        //Al atributo Id no es necesario ponerle requerimientos porque se obtiene automaticamente
        //del gestor de la base de datos al ingresar un registro ya que se estableció como autoincrementable
        public int IdGrupo { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        public int IdCarrera { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        public int IdMateria { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        public int IdProfesor { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        public int Ciclo { get; set; }

        [Required(ErrorMessage = "Éste es un campo requerido")]
        public int Anio { get; set; }
    }
}
