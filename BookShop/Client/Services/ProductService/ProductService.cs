﻿using BookShop.Shared;
using System.Net.Http.Json;

namespace BookShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action? OnChange;

        public List<Product>? Products { get; set; } = new List<Product>();

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadProductsAsync(string? categoryUrl = null)
        {

            Products = await _http.GetFromJsonAsync<List<Product>?>( categoryUrl == null 
                                                                  ? $"Product"
                                                                  : $"Product/Category/{categoryUrl}");            
            
            OnChange?.Invoke();
        }

        public async Task<Product?> GetProductAsync(int id)
        {
            return await _http.GetFromJsonAsync<Product?>($"Product/{id}");
        }

        public async Task<List<Product>?> SearchProductsAsync(string searchText)
        {
            return await _http.GetFromJsonAsync<List<Product>?>($"Product/Search/{searchText}");
        }
    }
}
