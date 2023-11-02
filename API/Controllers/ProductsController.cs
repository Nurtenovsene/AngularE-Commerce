using API.Core.DbModels;
using API.Core.Interfaces;
using API.Infrastructure.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly IProductRepository _productRepository;
        private readonly IGenericRepository<Product> _productRepository; 
        private readonly IGenericRepository<ProductBrand> _productBrandRepository; 
        private readonly IGenericRepository<ProductType> _productTypeRepository; 
        public ProductsController(IGenericRepository<Product> productRepository,
            IGenericRepository<ProductBrand> productBrandRepository, 
            IGenericRepository<ProductType> productTypeRepository)
        {
            _productRepository = productRepository;
            _productBrandRepository = productBrandRepository;
            _productTypeRepository = productTypeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var result = await _productRepository.ListAllAsync();
            return Ok(result);  
        }
        [HttpGet("product/{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var result = await _productRepository.GetById(id);
            return Ok(result);
        }
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            var result = await _productRepository.ListAllAsync();
            return Ok(result);
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductType>>> GetProductTypes()
        {
            var result = await _productRepository.ListAllAsync();
            return Ok(result);
        }
    }
}
