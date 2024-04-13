using ADSProject.Interfaces;
using ADSProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProject.Controllers
{
    [Route("api/carreras/")]
    public class CarrerasController : ControllerBase
    {
        private readonly ICarrera carrera;
        private const string COD_EXITO = "000000";
        private const string COD_ERROR = "999999";
        private string pCodRespuesta;
        private string pMensajeUsuario;
        private string pMensajeTecnico;

        public CarrerasController(ICarrera carrera)
        {
            this.carrera = carrera;
        }

        [HttpPost("agregarCarrera")]
        public ActionResult<string> AgregarCarrera([FromBody] Carrera carrera)
        {
            try
            {
                //Verificar que todas las validaciones por atributo del modelo estén correctas
                if (!ModelState.IsValid)
                {
                    //En caso de no cumplir con todas las validaciones se procede a retornar una respuesta erronea
                    return BadRequest(ModelState);
                }

                int contador = this.carrera.AgregarCarrera(carrera);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro insertado con éxito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un error al insertar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("actualizarCarrera/{idCarrera}")]
        public ActionResult<string> ActualizarCarrera(int idCarrera, [FromBody] Carrera carrera)
        {
            try
            {
                //Verificar que todas las validaciones por atributo del modelo estén correctas
                if (!ModelState.IsValid)
                {
                    //En caso de no cumplir con todas las validaciones se procede a retornar una respuesta erronea
                    return BadRequest(ModelState);
                }

                int contador = this.carrera.ActualizarCarrera(idCarrera, carrera);

                if (contador > 0)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro actualizado con éxito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un error al actualizar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpDelete("eliminarCarrera/{idCarrera}")]
        public ActionResult<string> EliminarCarrera(int idCarrera)
        {
            try
            {
                bool eliminado = this.carrera.EliminarCarrera(idCarrera);

                if (eliminado)
                {
                    pCodRespuesta = COD_EXITO;
                    pMensajeUsuario = "Registro eliminado con éxito";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "Ocurrio un error al eliminar el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;
                }

                return Ok(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet("obtenerCarreraPorId/{idCarrera}")]
        public ActionResult<Carrera> ObtenerCarreraPorId(int idCarrera)
        {
            try
            {
                Carrera carrera = this.carrera.ObtenerCarreraPorId(idCarrera);

                if (carrera != null)
                {
                    return Ok(carrera);
                }
                else
                {
                    pCodRespuesta = COD_ERROR;
                    pMensajeUsuario = "No se encontro el registro";
                    pMensajeTecnico = pCodRespuesta + " || " + pMensajeUsuario;

                    return NotFound(new { pCodRespuesta, pMensajeUsuario, pMensajeTecnico });
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        [HttpGet("obtenerCarreras")]
        public ActionResult<List<Carrera>> ObtenerCarreras()
        {
            try
            {
                List<Carrera> lstCarreras = this.carrera.ObtenerTodasLasCarreras();

                return Ok(lstCarreras);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
