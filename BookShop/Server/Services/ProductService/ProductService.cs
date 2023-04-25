using BookShop.Server.Data;
using BookShop.Server.Services.CategoryService;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context)
        {            
            _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .Include(p => p.Variants)
                                          .ThenInclude(p => p.Edition)
                                          .ToListAsync();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            var product = await _context.Products
                               .Include(p => p.Category)
                               .Include(p => p.Variants)
                               .ThenInclude(v => v.Edition)
                               .FirstOrDefaultAsync(p => p.Id == id);
            if (product != null)
            {
                product.Views++;
                await _context.SaveChangesAsync();
            }
            
            return product;
        }

        public async Task<List<Product>?> GetProductsByCategoryAsync(string categoryUrl)
        {
            Category? category = await _categoryService.GetCategoryByUrlAsync(categoryUrl);
            if (category != null)
            {
                return await _context.Products.Include(p => p.Variants)
                                              .Where(p => p.CategoryId == category.Id).ToListAsync();
            }

            return null;
        }

        public async Task<List<Product>?> SearchProductsAsync(string searchText)
        {
            return await _context.Products.Where(p => (p.Title != null && p.Title.ToLower().Contains(searchText.ToLower()))
                                 || (p.Description != null && p.Description.ToLower().Contains(searchText.ToLower())))
                                 .ToListAsync();             
        }
    }
}
