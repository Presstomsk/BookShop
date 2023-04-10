using BookShop.Shared;

namespace BookShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category 
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books",
                    Icon = "book"
                }
            };
        }
    }
}
