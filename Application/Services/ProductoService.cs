using Domain.Entities;
using Application.Interfaces;

namespace Application.Services
{
    public class ProductoService : IProductoService
    {

        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public async Task<IEnumerable<Producto>> GetAllProductsAsync()
        {
            return await _productoRepository.GetAllAsync();
        }

        public async Task<Producto> GetProductByIdAsync(int id)
        {
            return await _productoRepository.GetByIdAsync(id);
        }

        public async Task<Producto> CreateProductAsync(Producto producto)
        {
            await _productoRepository.AddAsync(producto);
            return producto;
        }

        public async Task UpdateProductAsync(Producto producto)
        {
            await _productoRepository.UpdateAsync(producto);
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productoRepository.DeleteAsync(id);
        }

    }
}