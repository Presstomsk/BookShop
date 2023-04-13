﻿using BookShop.Server.Data;
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
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            return await _context.Products.Include(p => p.Editions)
                                 .FirstOrDefaultAsync(p => p.Id == id);            
        }

        public async Task<List<Product>?> GetProductsByCategoryAsync(string categoryUrl)
        {
            Category? category = await _categoryService.GetCategoryByUrlAsync(categoryUrl);
            if (category != null)
            {
                return await _context.Products.Where(p => p.CategoryId == category.Id).ToListAsync();
            }

            return null;
        }       
    }
}
