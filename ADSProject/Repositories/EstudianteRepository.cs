using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class EstudianteRepository : IEstudiante
    {
        private List<Estudiante> lstEstudiantes = new List<Estudiante>
        {
            new Estudiante{ IdEstudiante = 1, NombresEstudiante = "JUAN CARLOS",
                ApellidosEstudiante = "PEREZ SOSA", CodigoEstudiante = "PS24I04002",
                CorreoEstudiante = "ps24I04002@usonsonate.edu.sv"}
        };

        public int AgregarEstudiante(Estudiante estudiante)
        {
            try
            {
                /* Validar si existen datos en la lista, de ser así, tomaremos el último ID
                 y lo incrementamos en una unidad */
                if (lstEstudiantes.Count > 0)
                {
                    estudiante.IdEstudiante = lstEstudiantes.Last().IdEstudiante + 1;
                }

                lstEstudiantes.Add(estudiante);

                return estudiante.IdEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarEstudiante(int idEstudiante, Estudiante estudiante)
        {
            try
            {
                // Obtenemos el indice del objeto a actualizar
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                //Procedemos con la actualización
                lstEstudiantes[indice] = estudiante;

                return idEstudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarEstudiante(int idEstudiante)
        {
            try
            {
                // Obtenemos el indice del objeto a eliminar
                int indice = lstEstudiantes.FindIndex(tmp => tmp.IdEstudiante == idEstudiante);

                //Procedemos con la eliminación del objeto
                lstEstudiantes.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Estudiante ObtenerEstudiantePorId(int idEstudiante)
        {
            try
            {
                // Buscamos y asignamos el objeto estudiante
                Estudiante estudiante = lstEstudiantes.FirstOrDefault(tmp => tmp.IdEstudiante == idEstudiante);

                return estudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Estudiante> ObtenerTodosLosEstudiantes()
        {
            try
            {
                return lstEstudiantes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
