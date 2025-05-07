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
        public async Task<ActionResult<IEnumerable<Producto>>> GetAllProducts()
        {
            var productos = await _productoService.GetAllProductsAsync();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProductById(int id)
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
                Precio = productoDto.Precio,
                Descripcion = productoDto.Descripcion
            };
            await _productoService.CreateProductAsync(producto);

            var RespuestaProductoDto = new RespuestaProductoDto
            {
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                Descripcion = producto.Descripcion
            };
            return Ok(new { message = "Created successfully", Object = RespuestaProductoDto });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductoDto productoDto)
        {
            var producto = await _productoService.GetProductByIdAsync(id);
            if (producto == null)
            {
                return NotFound(new { message = "Product not found" });
            }

            producto.Nombre = productoDto.Nombre;
            producto.Precio = productoDto.Precio;
            producto.Descripcion = productoDto.Descripcion;

            await _productoService.UpdateProductAsync(producto);

            return Ok(new { message = "Updated successfully" });
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