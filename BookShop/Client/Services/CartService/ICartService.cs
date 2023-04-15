using BookShop.Shared;

namespace BookShop.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCartAsync(ProductVariant productVariant);
    }
}
