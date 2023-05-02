using BookShop.Server.Data;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _dataContext;

        public OrderService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateOrder(Guid orderId, string? email)
        {
            var order = new Order
            {
                Id = orderId,
                Email = email,
                Status = OrderStatus.Created
            };

            _dataContext.Add(order);
            _dataContext.SaveChanges();
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _dataContext.Orders.ToListAsync();
        }

        public async Task UpdateOrderStatusByAdministratorAsync(Guid orderId, OrderStatus orderStatus)
        {
            if (orderStatus == OrderStatus.Confirmed || orderStatus == OrderStatus.Sent)
            {
                var order = await _dataContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);

                if (order != null && order.Status != OrderStatus.Fail)
                {
                    order.Status = orderStatus;
                    await _dataContext.SaveChangesAsync();
                }
            }
        }

        public async Task UpdateOrderStatusByClientAsync(Guid orderId, OrderStatus orderStatus)
        {
            if (orderStatus == OrderStatus.Success || orderStatus == OrderStatus.Fail)
            {
                var order = await _dataContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);

                if (order?.Status == OrderStatus.Created)
                {
                    order.Status = orderStatus;
                    await _dataContext.SaveChangesAsync();
                }
            }
        }
    }
}
