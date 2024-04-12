using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class ProfesorRepository : IProfesor
    {
        private List<Profesor> lstProfesores = new List<Profesor>
        {
            new Profesor{ IdProfesor = 1, NombresProfesor = "José Dimas", ApellidosProfesor = "Carabantes García"}
        };

        public int AgregarProfesor(Profesor profesor)
        {
            try
            {
                /* Validar si existen datos en la lista, de ser así, tomaremos el último ID
                 y lo incrementamos en una unidad */
                if (lstProfesores.Count > 0)
                {
                    profesor.IdProfesor = lstProfesores.Last().IdProfesor + 1;
                }

                lstProfesores.Add(profesor);

                return profesor.IdProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarProfesor(int idProfesor, Profesor profesor)
        {
            try
            {
                // Obtenemos el indice del objeto a actualizar
                int indice = lstProfesores.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                //Procedemos con la actualización
                lstProfesores[indice] = profesor;

                return idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarProfesor(int idProfesor)
        {
            try
            {
                // Obtenemos el indice del objeto a eliminar
                int indice = lstProfesores.FindIndex(tmp => tmp.IdProfesor == idProfesor);

                //Procedemos con la eliminación del objeto
                lstProfesores.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Profesor ObtenerProfesorPorId(int idProfesor)
        {
            try
            {
                // Buscamos y asignamos el objeto estudiante
                Profesor profesor = lstProfesores.FirstOrDefault(tmp => tmp.IdProfesor == idProfesor);

                return profesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Profesor> ObtenerTodosLosProfesores()
        {
            try
            {
                return lstProfesores;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
