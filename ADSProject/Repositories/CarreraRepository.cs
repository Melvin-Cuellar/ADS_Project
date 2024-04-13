using ADSProject.Interfaces;
using ADSProject.Models;

namespace ADSProject.Repositories
{
    public class CarreraRepository : ICarrera
    {
        private List<Carrera> lstCarreras = new List<Carrera>
        {
            new Carrera{ Id = 1, Codigo = "04", Nombre = "Ingeniería en sistemas computacionales"}
        };

        public int AgregarCarrera(Carrera carrera)
        {
            try
            {
                /* Validar si existen datos en la lista, de ser así, tomaremos el último ID
                 y lo incrementamos en una unidad */
                if (lstCarreras.Count > 0)
                {
                    carrera.Id = lstCarreras.Last().Id + 1;
                }

                lstCarreras.Add(carrera);

                return carrera.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarCarrera(int idCarrera, Carrera carrera)
        {
            try
            {
                // Obtenemos el indice del objeto a actualizar
                int indice = lstCarreras.FindIndex(tmp => tmp.Id == idCarrera);

                //Procedemos con la actualización
                lstCarreras[indice] = carrera;

                return idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarCarrera(int idCarrera)
        {
            try
            {
                // Obtenemos el indice del objeto a eliminar
                int indice = lstCarreras.FindIndex(tmp => tmp.Id == idCarrera);

                //Procedemos con la eliminación del objeto
                lstCarreras.RemoveAt(indice);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Carrera ObtenerCarreraPorId(int idCarrera)
        {
            try
            {
                // Buscamos y asignamos el objeto estudiante
                Carrera carrera = lstCarreras.FirstOrDefault(tmp => tmp.Id == idCarrera);

                return carrera;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Carrera> ObtenerTodasLasCarreras()
        {
            try
            {
                return lstCarreras;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
