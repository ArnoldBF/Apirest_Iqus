using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProductoService
    {

        Task<IEnumerable<Producto>> GetAllProductsAsync();

        Task<Producto> GetProductByIdAsync(int id);

        Task<Producto> CreateProductAsync(Producto producto);

        Task UpdateProductAsync(Producto producto);

        Task DeleteProductAsync(int id);

    }
}