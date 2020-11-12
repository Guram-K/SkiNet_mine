using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction
{
    public interface IProductBrandRepository
    {
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
    }
}
