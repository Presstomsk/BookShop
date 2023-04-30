using BookShop.Server.Services.StatsService;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace BookShop.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _statsService;

        public StatsController(IStatsService statsService)
        {
            _statsService = statsService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisitsAsync()
        {
            return Ok(await _statsService.GetVisitsAsync());
        }

        [HttpPost]
        public async Task IncrementVisitsAsync([FromHeader]string email)
        {           
            await _statsService.IncrementVisitsAsync(email);
        }
    }
}
