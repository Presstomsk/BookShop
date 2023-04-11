using BookShop.Server.Services.ProductService;
using BookShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProductsAsync()
        {
            return Ok(await _productService.GetAllProductsAsync());
        }

        [HttpGet("Category/{categoryUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByCategoryAsync(string categoryUrl)
        {
            return Ok(await _productService.GetProductsByCategoryAsync(categoryUrl));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product?>> GetProductAsync(int id)
        {
            return Ok(await _productService.GetProductAsync(id));
        }
    }
}
