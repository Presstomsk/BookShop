
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
        [HttpPost("addbook")]
        public void CreateProduct()
        {

        }
    }
}
