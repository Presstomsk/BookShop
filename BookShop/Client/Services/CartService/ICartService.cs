using BookShop.Shared;

namespace BookShop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCartAsync(CartItem cartItem);
        Task<List<CartItem>> GetCartItemsAsync();
        Task DeleteCartItemAsync(CartItem item);
        Task EmptyCartAsync();
        Task<string> CheckoutAsync(string email);
    }
}
