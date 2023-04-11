using BookShop.Shared;
using System.Net.Http.Json;

namespace BookShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public List<Category>? Categories { get; set; } = new List<Category>();      

        public CategoryService(HttpClient http)
        {
            _http = http;           
        }

        public async Task LoadCategoriesAsync()
        {
            Categories = await _http.GetFromJsonAsync<List<Category>>("Category");
        }
    }
}
