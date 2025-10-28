using Microsoft.AspNetCore.Mvc;

namespace TiendaDB;

[ApiController]
[Route("Tienda")]
public class PresupuestosController : ControllerBase
{
    PresupuestosRepository presupuestosRepository;

    public PresupuestosController()
    {
        presupuestosRepository = new PresupuestosRepository();
    }

    [HttpGet("api/Presupuesto/{id}")]
    public IActionResult getProductoById(int id)
    {
        return Ok(presupuestosRepository.getPresupuestosById(id));
    }

}