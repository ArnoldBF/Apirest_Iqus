using Microsoft.AspNetCore.Mvc;
using Application.Dtos.Producto;
using Application.Interfaces;
using Domain.Entities;


namespace Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {

        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetAllProducts()
        {
            var productos = await _productoService.GetAllProductsAsync();

            if (!productos.Any())
            {
                return Ok(new List<ProductoDto>());
            }
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductoDto>> GetProductById(int id)
        {
            var producto = await _productoService.GetProductByIdAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct(CrearProductoDto productoDto)
        {
            var producto = new Producto
            {
                Nombre = productoDto.Nombre,
                PrecioUnitario = productoDto.PrecioUnitario,
                Descripcion = productoDto.Descripcion
            };
            await _productoService.CreateProductAsync(producto);

            var RespuestaProductoDto = new RespuestaProductoDto
            {
                Nombre = producto.Nombre,
                PrecioUnitario = producto.PrecioUnitario,
                Descripcion = producto.Descripcion
            };
            return Ok(new { message = "Created successfully", Object = RespuestaProductoDto });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductoDto productoDto)
        {
            try
            {
                var producto = await _productoService.GetProductByIdAsync(id);
                if (producto == null)
                {
                    return NotFound(new { message = "El producto no existe o ya fue eliminado." });
                }

                producto.Nombre = productoDto.Nombre;
                producto.PrecioUnitario = productoDto.PrecioUnitario;
                producto.Descripcion = productoDto.Descripcion;

                await _productoService.UpdateProductAsync(producto);

                return Ok(new { message = "Producto actualizado exitosamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error interno del servidor", details = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {

            var producto = await _productoService.GetProductByIdAsync(id);
            if (producto == null)
            {
                return NotFound(new { message = "Product not found" });
            }



            await _productoService.DeleteProductAsync(id);
            return Ok(new { message = " Item permanently deleted" });


        }
    }
}