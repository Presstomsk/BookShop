using Blazored.LocalStorage;
using BookShop.Shared;
using static System.Net.WebRequestMethods;
using System.Net.Http.Json;

namespace BookShop.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public OrderService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "/Order/getOrders");
            request.Headers.Add("Authorization", "Bearer " + await _localStorageService.GetItemAsync<string>("token"));

            using (var response = await _httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadFromJsonAsync<List<Order>>();
                return result!;
            }
        }

        public async Task UpdateOrderStatusByAdministratorAsync(Guid orderId, OrderStatus orderStatus)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/Order/administrator/updateOrder");
            request.Headers.Add("Authorization", "Bearer " + await _localStorageService.GetItemAsync<string>("token"));
            var orderDto = new OrderDto
            {
                OrderId = orderId,
                Status = orderStatus
            };
            request.Content = JsonContent.Create(orderDto, typeof(OrderDto));

            await _httpClient.SendAsync(request);
        }

        public async Task UpdateOrderStatusByClientAsync(Guid orderId, OrderStatus orderStatus)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/Order/client/updateOrder");
            request.Headers.Add("Authorization", "Bearer " + await _localStorageService.GetItemAsync<string>("token"));
            var orderDto = new OrderDto
            {
                OrderId = orderId,
                Status = orderStatus
            };            
            request.Content = JsonContent.Create(orderDto, typeof(OrderDto));

            await _httpClient.SendAsync(request);
        }
    }
}
