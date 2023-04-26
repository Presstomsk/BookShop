using Blazored.LocalStorage;
using BookShop.Client.Services.CategoryService;
using BookShop.Client.Services.EditionService;
using BookShop.Client.Services.ProductService;
using BookShop.Shared;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace BookShop.Client.Services.AdministrateService
{
    public class AdministrateService : IAdministrateService
    {        
        private readonly HttpClient _http;       
        private readonly ILocalStorageService _localStorageService;

        public AdministrateService(HttpClient http, ILocalStorageService localStorageService)
        {            
            _http = http;            
            _localStorageService = localStorageService;
        }

        public async Task<List<ExtendedProduct>> LoadExtendedProductsAsync()
        {
            var extendedProducts = new List<ExtendedProduct>();
            var products = await _http.GetFromJsonAsync<List<Product>?>("Product");

            if (products != null)
            {
                foreach (var product in products)
                {
                    foreach (var variant in product.Variants)
                    {
                        extendedProducts?.Add(new ExtendedProduct
                        {
                            ProductId = product.Id,
                            EditionId = variant.EditionId,
                            Title = product.Title,
                            Description = product.Description,
                            Image = product.Image,
                            CategoryName = product.Category?.Name,
                            EditionName = variant.Edition?.Name,
                            Price = variant.Price,
                            OriginalPrice = variant.OriginalPrice,
                            DateCreated = product.DateCreated,
                            DateUpdated = product.DateUpdated,
                            Views = product.Views
                        });
                    }
                }
            }

            return extendedProducts;
        }

        public async Task CreateProductAsync(ExtendedProduct extendedProduct)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/Administrate/addbook");
            request.Headers.Add("Authorization", "Bearer " + await _localStorageService.GetItemAsync<string>("token"));
            request.Content = JsonContent.Create(extendedProduct, typeof(ExtendedProduct));

            using (var response = await _http.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
            }
        }

        public async Task UpdateProductAsync(ExtendedProduct extendedProduct)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/Administrate/updatebook");
            request.Headers.Add("Authorization", "Bearer " + await _localStorageService.GetItemAsync<string>("token"));
            request.Content = JsonContent.Create(extendedProduct, typeof(ExtendedProduct));

            using (var response = await _http.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
            }
        }

        public async Task DeleteProductAsync(ExtendedProduct extendedProduct)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "/Administrate/deletebook");
            request.Headers.Add("Authorization", "Bearer " + await _localStorageService.GetItemAsync<string>("token"));
            request.Content = JsonContent.Create(extendedProduct, typeof(ExtendedProduct));

            using (var response = await _http.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
