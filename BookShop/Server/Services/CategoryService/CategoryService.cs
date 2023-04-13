using BookShop.Server.Data;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetCategoryByUrlAsync(string categoryUrl)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Url != null 
                                            && c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
