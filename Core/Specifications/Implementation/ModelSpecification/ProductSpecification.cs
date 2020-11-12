using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Specifications
{
    public class ProductSpecification : BaseSpecification<Product>
    {
        public ProductSpecification()
        {
            AddInculde(x => x.ProductType);
            AddInculde(x => x.ProductBrand);
        }

        public ProductSpecification(int id) : base(x => x.Id == id)
        {
            AddInculde(x => x.ProductType);
            AddInculde(x => x.ProductBrand);
        }
    }
}
