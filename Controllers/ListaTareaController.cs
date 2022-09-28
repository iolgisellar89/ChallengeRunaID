using ChallengeRunaID.Models;
using ChallengeRunaID.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace ChallengeRunaID.Controllers
{
    [ApiController]
    [Route("/api/listaTareas")]
    public class ListaTareaController : ControllerBase
    {     

        [HttpGet]
        [Route("lista")]
        public ActionResult<List<ListaTarea>> GetAll()
        {
            return ListaTareaService.GetAll();
        }

        [HttpGet]
        [Route("traerPorId/{id}")]
        public ActionResult<ListaTarea> Get(Guid id)
        {
            var _return = ListaTareaService.GetById(id);
            if (_return == null)
                return NotFound();


            return _return;
        }

        [HttpPost]
        [Route("crearListaTarea")]
        public ActionResult Create(ListaTarea listaTarea)
        {
            ListaTareaService.Add(listaTarea);

            return CreatedAtAction(
                "Get",
                new { id = listaTarea.Id },
                listaTarea
                );
        }


        [HttpPut]
        [Route("actualizar/{id}")]
        public ActionResult Update(Guid id, ListaTarea listaTarea)
        {

            var originalEntry = ListaTareaService.GetById(id);
            if (originalEntry == null)
                return NotFound();


            ListaTareaService.Update(id, listaTarea);
            return Ok();
            

        }

        [HttpDelete]
        [Route("eliminar/{id}")]
        public ActionResult Delete(Guid id)
        {

            var listaEliminar = ListaTareaService.GetById(id);
            if (listaEliminar == null)
                return NotFound();

            ListaTareaService.Delete(id);

            return Ok();


        }
        
    }
}