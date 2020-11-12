using Core.Abstraction;
using Core.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductBrandRepository : IProductBrandRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductBrandRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _dbContext.ProductBrands.ToListAsync();
        }
    }
}
