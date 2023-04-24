using BookShop.Shared;
using System.Net.Http.Json;

namespace BookShop.Client.Services.EditionService
{
    public class EditionService : IEditionService
    {
        private readonly HttpClient _http;

        public EditionService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Edition>?> GetAllEditionsAsync()
        {
            return await _http.GetFromJsonAsync<List<Edition>?>("Edition");
        }
    }
}
