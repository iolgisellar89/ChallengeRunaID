using ChallengeRunaID.Models;
using ChallengeRunaID.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeRunaID.Controllers
{
    [ApiController]
    [Route("/api/tareas")]
    public class TareaController : ControllerBase
    {
        

        [HttpGet]
        [Route("lista/{categoria?}")]
        public ActionResult<List<Tarea>> GetAll(string ? categoria = "")
        {
            if (categoria == string.Empty)
                return TareaService.GetAll();
            return TareaService.GetByCategoria(categoria);
        }

        [HttpGet]
        [Route("traerPorId/{id}")]
        public ActionResult<Tarea> Get(Guid id)
        {
            var _return = TareaService.GetById(id);
            if (_return == null)
                return NotFound();


            return _return;
        }

        [HttpPost]
        [Route("crearTarea")]
        public ActionResult Create(Tarea tarea)
        {
            TareaService.Add(tarea);

            return CreatedAtAction(
                "Get",
                new { id = tarea.Id },
                tarea
                );
        }

        [HttpPut]
        [Route("actualizar/{id}")]
        public ActionResult Update(Guid id, Tarea tarea)
        {

            var originalEntry = TareaService.GetById(id);
            if (originalEntry == null)
                return NotFound();


            TareaService.Update(id, tarea);
            return Ok();

        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public ActionResult Delete(Guid id)
        {

            var listaEliminar = TareaService.GetById(id);
            if (listaEliminar == null)
                return NotFound();

            TareaService.Delete(id);

            return Ok();

        }        

    }
}
