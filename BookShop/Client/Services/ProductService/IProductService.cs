using BookShop.Shared;

namespace BookShop.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action? OnChange;
        List<Product>? Products { get; set; }
        Task LoadProductsAsync(string? categoryUrl = null);
        Task<Product?> GetProductAsync(int id);
        Task<List<Product>?> SearchProductsAsync(string searchText);
    }
}
