using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class MateriaRepository : IMateria
    {
        private List<Materia> lstMaterias = new List<Materia>
        {
            new Materia{ IdMateria = 1, NombreMateria = "Análisis de sistemas"}
        };

        public int AgregarMateria(Materia materia)
        {
            try
            {
                /* Validar si existen datos en la lista, de ser así, tomaremos el último ID
                 y lo incrementamos en una unidad */
                if (lstMaterias.Count > 0)
                {
                    materia.IdMateria = lstMaterias.Last().IdMateria + 1;
                }

                lstMaterias.Add(materia);

                return materia.IdMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarMateria(int idMateria, Materia materia)
        {
            try
            {
                // Obtenemos el indice del objeto a actualizar
                int indice = lstMaterias.FindIndex(tmp => tmp.IdMateria == idMateria);

                //Procedemos con la actualización
                lstMaterias[indice] = materia;

                return idMateria;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarMateria(int idMateria)
        {
            try
            {
                // Obtenemos el indice del objeto a eliminar
                int indice = lstMaterias.FindIndex(tmp => tmp.IdMateria == idMateria);

                //Procedemos con la eliminación del objeto
                lstMaterias.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Materia ObtenerMateriaPorId(int idMateria)
        {
            try
            {
                // Buscamos y asignamos el objeto estudiante
                Materia materia = lstMaterias.FirstOrDefault(tmp => tmp.IdMateria == idMateria);

                return materia;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Materia> ObtenerTodasLasMaterias()
        {
            try
            {
                return lstMaterias;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
