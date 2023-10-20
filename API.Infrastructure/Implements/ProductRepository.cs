using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace API.Infrastructure.Implements
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
                _context = context; 
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return product;
        }
        public async Task<ReadOnlyList<Product>> GetProductAsync()
        {
           var productList=await _context.Products.ToListAsync();
            return productList; 
        }

        public async Task<ReadOnlyList<ProductBrand>> GetProductBrandByIdAsync()
        {
            var productBrandList=await _context.ProductsBrands.ToListAsync();
            return productBrandList;
        }

        public async Task<ReadOnlyList<ProductType>> GetProductTypeByIdAsync()
        {
            var productTypeList=await _context.ProductsTypes.ToListAsync();
            return productTypeList;
        }
    }
}
