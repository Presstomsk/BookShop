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

        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");

            if (cart == null)
            {
                return result;
            }           

            foreach(var item in cart)
            {
                var product = await _productService.GetProductAsync(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product!.Id,
                    ProductTitle = product!.Title,
                    Image = product!.Image,
                    EditionId = item.EditionId
                };
                var variant = product.Variants.FirstOrDefault(v => v.EditionId == item.EditionId);

                if (variant != null)
                {
                    cartItem.EditionName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }

                result.Add(cartItem);
            }

            return result;
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
    }
}
