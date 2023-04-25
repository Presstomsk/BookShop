
using BookShop.Server.Services.AdministrateService;
using BookShop.Shared;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Administrator")]
    public class AdministrateController : ControllerBase
    {
        private readonly IAdministrateService _administrateService;

        public AdministrateController(IAdministrateService administrateService)
        {
            _administrateService = administrateService;
        }

        [HttpPost("addbook")]
        public async Task CreateProductAsync(ExtendedProduct extendedProduct)
        {
            await _administrateService.CreateProductAsync(extendedProduct);
        }

        [HttpPost("updatebook")]
        public async Task UpdateProductAsync(ExtendedProduct extendedProduct)
        {
            await _administrateService.UpdateProductAsync(extendedProduct);
        }
    }
}
