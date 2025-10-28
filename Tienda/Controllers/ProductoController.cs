using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TiendaDB;

[ApiController]
[Route("Tienda")]
public class ProductoController : ControllerBase
{
    ProductoRepository productoRepository;
    public ProductoController()
    {
        productoRepository = new ProductoRepository();
    }

    [HttpPost("api/Producto")]
    public IActionResult addNewProducto(Productos producto)
    {
        if (productoRepository.addNewProducto(producto))
        {
            return Ok("Producto Creado Correctamente!");
        }
        else
        {
            return BadRequest("Ocurrio un error! No se pudo crear el producto.");
        }
    }

    [HttpPut("api/Producto/{Id}")]
    public IActionResult updateProducto(int Id, Productos producto)
    {



        if (productoRepository.updateProducto(Id, producto))
        {
            return Ok($"Producto con id = {Id} modificado correctamente");
        }
        else
        {
            return BadRequest("No se puedo modificar el producto!");
        }

    }

    [HttpGet("api/Producto")]
    public IActionResult getProductos()
    {
        var listadoProductos = productoRepository.getProductos();

        return Ok(listadoProductos);
    }

    [HttpGet("api/Producto/{Id}")]
    public IActionResult getProductosById(int Id)
    {
        var productoBuscado = productoRepository.getProductosById(Id);

        return Ok(productoBuscado);

    }

    [HttpDelete("api/Producto/{Id}")]
    public IActionResult deleteProductosById(int Id)
    {
        var productoElimado = productoRepository.deleteProductoById(Id);

        if (productoElimado)
        {
            return Ok($"Producto con ID = {Id} eliminado correctamente");
        }

        return BadRequest("No se pudo eliminar el producto!");
    }
}