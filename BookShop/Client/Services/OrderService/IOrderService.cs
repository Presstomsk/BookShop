using BookShop.Shared;

namespace BookShop.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task UpdateOrderStatusByClientAsync(Guid orderId, OrderStatus orderStatus);
        Task UpdateOrderStatusByAdministratorAsync(Guid orderId, OrderStatus orderStatus);
        Task<List<Order>> GetOrdersAsync();
    }
}
