using API.Core.DbModels;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.Core.Specifications
{
    public class ProductsWithProductTypeAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithProductTypeAndBrandsSpecification(string sort)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
            //AddOrderBy(x => x.Name);
            if (!string.IsNullOrWhiteSpace(sort))
            {
                switch(sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDesc(p => p.Price);
                        break;
                    default:
                        AddOrderBy(x => x.Name);
                        break;
                }
            }
        }
        public ProductsWithProductTypeAndBrandsSpecification(int id)
            : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}
