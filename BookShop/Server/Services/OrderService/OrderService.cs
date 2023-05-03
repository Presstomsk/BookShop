using BookShop.Server.Data;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _dataContext;

        private Dictionary<OrderStatus, string> _orderStatuses = new Dictionary<OrderStatus, string>
        {
            {OrderStatus.Created, StringConsts.CREATED},
            {OrderStatus.Fail, StringConsts.FAIL},
            {OrderStatus.Success, StringConsts.SUCCESS},
            {OrderStatus.Confirmed, StringConsts.CONFIRMED},
            {OrderStatus.Sent, StringConsts.SENT}
        };

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
                Status = OrderStatus.Created,
                TextOrderStatus = _orderStatuses[OrderStatus.Created]
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
            if (orderStatus == OrderStatus.Confirmed 
                || orderStatus == OrderStatus.Sent
                || orderStatus == OrderStatus.Success)
            {
                var order = await _dataContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId);

                if (order != null && order.Status != OrderStatus.Fail)
                {
                    order.Status = orderStatus;
                    order.TextOrderStatus = _orderStatuses[orderStatus];
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
                    order.TextOrderStatus = _orderStatuses[orderStatus];
                    await _dataContext.SaveChangesAsync();
                }
            }
        }
    }
}
