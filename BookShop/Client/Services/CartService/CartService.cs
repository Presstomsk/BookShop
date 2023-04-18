using Blazored.LocalStorage;
using Blazored.Toast.Services;
using BookShop.Client.Services.ProductService;
using BookShop.Shared;
using System.Net.Http.Json;

namespace BookShop.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;
        private readonly HttpClient _httpClient;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage
                         , IToastService toastService
                         , IProductService productService
                         , HttpClient httpClient)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
            _httpClient = httpClient;
        }

        public async Task AddToCartAsync(CartItem cartItem)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");

            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart.FirstOrDefault(c => c.ProductId == cartItem.ProductId
                                                 && c.EditionId == cartItem.EditionId);

            if (sameItem == null)
            {
                cart.Add(cartItem);
            }
            else
            {
                sameItem.Quantity += cartItem.Quantity;
            }
            
            await _localStorage.SetItemAsync("cart", cart);
            var product = await _productService.GetProductAsync(cartItem.ProductId);
            _toastService.ShowSuccess($"Товар {product!.Title} добавлен в корзину!");
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItemsAsync()
        {           
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            return cart ?? new List<CartItem>();            
        }

        public async Task DeleteCartItemAsync(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");

            if (cart == null)
            {
                return;
            }

            var cartItem = cart.FirstOrDefault(c => c.ProductId == item.ProductId
                                                    && c.EditionId == item.EditionId);
            if (cartItem != null)
            {
                cart.Remove(cartItem);
            }

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCartAsync()
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }

        public async Task<string> CheckoutAsync()
        {
            var result = await _httpClient.PostAsJsonAsync("Payment/checkout", await GetCartItemsAsync());
            var url = await result.Content.ReadAsStringAsync();
            return url;
        }
    }
}
