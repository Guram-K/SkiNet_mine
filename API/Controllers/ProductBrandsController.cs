using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Abstraction;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductBrandsController : ControllerBase
    {
        private readonly IProductBrandRepository _repo;

        public ProductBrandsController(IProductBrandRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetBrands()
        {
            var results = await _repo.GetProductBrandsAsync();
            
            return Ok(results);
        }
    }
}
