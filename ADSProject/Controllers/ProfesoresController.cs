using ADSProject.Interfaces;
using ADSProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADSProject.Controllers
{
    [Route("api/profesor/")]
    public class ProfesoresController : ControllerBase
    {
        private readonly IProfesor profesor;
        private const string COD_EXITO = "000000";
        private const string COD_ERROR = "999999";
        private string pCodRespuesta;
        private string pMensajeUsuario;
        private string pMensajeTecnico;

        public ProfesoresController(IProfesor profesor)
        {
            this.profesor = profesor;
        }

        [HttpPost("agregarProfesor")]
        public ActionResult<string> AgregarProfesor([FromBody] Profesor profesor)
        {
            try
            {
                //Verificar que todas las validaciones por atributo del modelo estén correctas
                if (!ModelState.IsValid)
                {
                    //En caso de no cumplir con todas las validaciones se procede a retornar una respuesta erronea
                    return BadRequest(ModelState);
                }

                int contador = this.profesor.AgregarProfesor(profesor);

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

        [HttpPost("actualizarProfesor/{idProfesor}")]
        public ActionResult<string> ActualizarProfesor(int idProfesor, [FromBody] Profesor profesor)
        {
            try
            {
                //Verificar que todas las validaciones por atributo del modelo estén correctas
                if (!ModelState.IsValid)
                {
                    //En caso de no cumplir con todas las validaciones se procede a retornar una respuesta erronea
                    return BadRequest(ModelState);
                }

                int contador = this.profesor.ActualizarProfesor(idProfesor, profesor);

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

        [HttpDelete("eliminarProfesor/{idProfesor}")]
        public ActionResult<string> EliminarProfesor(int idProfesor)
        {
            try
            {
                bool eliminado = this.profesor.EliminarProfesor(idProfesor);

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

        [HttpGet("obtenerProfesorPorId/{idProfesor}")]
        public ActionResult<Profesor> ObtenerProfesorPorId(int idProfesor)
        {
            try
            {
                Profesor profesor = this.profesor.ObtenerProfesorPorId(idProfesor);

                if (profesor != null)
                {
                    return Ok(profesor);
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

        [HttpGet("obtenerProfesores")]
        public ActionResult<List<Profesor>> ObtenerProfesores()
        {
            try
            {
                List<Profesor> lstProfesores = this.profesor.ObtenerTodosLosProfesores();

                return Ok(lstProfesores);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
