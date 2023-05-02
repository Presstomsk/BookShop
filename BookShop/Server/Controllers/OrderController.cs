using BookShop.Server.Services.OrderService;
using BookShop.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Server.Controllers
{    
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getOrders")]
        [Authorize(Roles = "Administrator")]
        public async Task<ActionResult<List<Order>>> GetOrdersAsync()
        {
            return Ok(await _orderService.GetOrdersAsync());
        }

        [HttpPost("client/updateOrder")]
        [Authorize]
        public async Task UpdateOrderStatusByClientAsync(OrderDto orderDto)
        {
            await _orderService.UpdateOrderStatusByClientAsync(orderDto.OrderId, orderDto.Status);
        }

        [HttpPost("administrator/updateOrder")]
        [Authorize(Roles = "Administrator")]
        public async Task UpdateOrderStatusByAdministratorAsync(OrderDto orderDto)
        {
            await _orderService.UpdateOrderStatusByAdministratorAsync(orderDto.OrderId, orderDto.Status);
        }
    }
}
