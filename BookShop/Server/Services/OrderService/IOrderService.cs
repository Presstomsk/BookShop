using BookShop.Shared;

namespace BookShop.Server.Services.OrderService
{
    public interface IOrderService
    {
        void CreateOrder(Guid orderId, string? email);
        Task UpdateOrderStatusByClientAsync(Guid orderId, OrderStatus orderStatus);
        Task UpdateOrderStatusByAdministratorAsync(Guid orderId, OrderStatus orderStatus);
        Task<List<Order>> GetOrdersAsync();
    }
}
