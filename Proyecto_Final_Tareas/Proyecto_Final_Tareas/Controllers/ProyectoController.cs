using AGE.Utils.Paginacion;
using Microsoft.AspNetCore.Mvc;
using Proyecto_Final_Tareas.Entities.DAO.Proyecto;
using Proyecto_Final_Tareas.Services.ProyectoService;

namespace Proyecto_Final_Tareas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProyectoController : Controller
    {
        private readonly IProyectoService _service;

        public ProyectoController(IProyectoService Service)
        {
            _service = Service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Page<ProyectoDAO>), 200)]
        public async Task<IActionResult> ConsultarTodos(
            [FromQuery] int? codigo,
            [FromQuery] string? descripcion,
            [FromQuery] Pageable pageable)
        {
            Page<ProyectoDAO> agePaisesDAOList =
                await _service.ConsultarTodos(codigo ?? 0, descripcion ?? "", pageable);

            return Ok(agePaisesDAOList);
        }
    }
}
