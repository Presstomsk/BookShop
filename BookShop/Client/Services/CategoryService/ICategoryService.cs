using BookShop.Shared;

namespace BookShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category>? Categories { get; set; }
        Task LoadCategoriesAsync();
    }
}
