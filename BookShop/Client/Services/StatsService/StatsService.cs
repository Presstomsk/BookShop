using Blazored.LocalStorage;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace BookShop.Client.Services.StatsService
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;

        public StatsService(HttpClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

        public async Task GetVisitsAsync()
        {
            int visits = int.Parse(await _client.GetStringAsync("Stats"));
            Console.WriteLine($"Visits: {visits}");
        }

        public async Task IncrementVisitsAsync(string username)
        {
            var content = new StringContent(string.Empty);
            content.Headers.Add("username", username);
            await _client.PostAsync("Stats", content);
        }
    }
}
