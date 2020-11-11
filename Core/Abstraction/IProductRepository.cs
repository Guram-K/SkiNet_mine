using Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Abstraction
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
