using BookShop.Client.Services.CategoryService;
using BookShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BookShop.Server.Controllers
{   
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
       
        public CategoryController()
        {            
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAsync()
        {
            return Ok(new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books",
                    Icon = "book"
                }
            });
        }
    }
}
