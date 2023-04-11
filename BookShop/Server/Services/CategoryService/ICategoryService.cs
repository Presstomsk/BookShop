using BookShop.Shared;

namespace BookShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
        Task<Category?> GetCategoryByUrlAsync(string categoryUrl);
    }
}
