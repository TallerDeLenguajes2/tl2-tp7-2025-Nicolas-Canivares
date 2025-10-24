using Microsoft.AspNetCore.Mvc;

namespace TiendaDB;

[ApiController]
[Route("Tienda")]
public class ProductoController : ControllerBase
{
    [HttpPost("api/Producto")]
    public IActionResult addNewProducto(Productos productos)
    {
        var productoACargar = new ProductoRepository();
        
        if (productoACargar.addNewProducto(productos))
        {
            return Ok("Producto Creado Correctamente!");
        }else
        {
            return BadRequest("Ocurrio un error! No se pudo crear el producto.");
        }
    }

}