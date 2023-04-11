using BookShop.Shared;

namespace BookShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books",
                    Icon = "book"
                }
            };

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return Categories;
        }

        public async Task<Category?> GetCategoryByUrlAsync(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url != null && c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
