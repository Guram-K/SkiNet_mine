using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstraction
{
    public interface IProductTypeRepository
    {
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
