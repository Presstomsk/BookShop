using BookShop.Server.Services.EditionService;
using BookShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{    
    [ApiController]
    [Route("[controller]")]
    public class EditionController : ControllerBase
    {
        private readonly IEditionService _editionService;

        public EditionController(IEditionService editionService)
        {
            _editionService = editionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Edition>>> GetAllEditionsAsync()
        {
            return Ok(await _editionService.GetAllEditionsAsync());
        }
    }
}
