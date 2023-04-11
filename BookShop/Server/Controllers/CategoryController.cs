using BookShop.Server.Services.CategoryService;
using BookShop.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategoriesAsync()
        {
            return Ok(await _categoryService.GetCategoriesAsync());
        }        
    }
}
