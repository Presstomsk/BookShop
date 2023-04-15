using Blazored.LocalStorage;
using Blazored.Toast.Services;
using BookShop.Client.Services.ProductService;
using BookShop.Shared;

namespace BookShop.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage
                         , IToastService toastService
                         , IProductService productService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        public async Task AddToCartAsync(ProductVariant productVariant)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");

            if (cart == null)
            {
                cart = new List<ProductVariant>();
            }

            cart.Add(productVariant);
            await _localStorage.SetItemAsync("cart", cart);
            var product = await _productService.GetProductAsync(productVariant.ProductId);
            _toastService.ShowSuccess($"Товар {product!.Title} добавлен в корзину!");
            OnChange.Invoke();
        }
    }
}
