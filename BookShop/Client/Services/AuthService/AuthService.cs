using BookShop.Client.Pages;
using BookShop.Shared;
using Newtonsoft.Json.Linq;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BookShop.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LoginResult?> LoginAsync(LoginModel loginModel)
        {
            var msg = await _httpClient.PostAsJsonAsync("Auth/login", loginModel);
            if (msg.IsSuccessStatusCode)
            {
                LoginResult? result = await msg.Content.ReadFromJsonAsync<LoginResult>();
                return result;
            }
            return null;
        }

        public async Task<LoginResult?> RegistrationAsync(RegModel regModel)
        {
            var msg = await _httpClient.PostAsJsonAsync("Auth/register", regModel);
            if (msg.IsSuccessStatusCode)
            {
                LoginResult? result = await msg.Content.ReadFromJsonAsync<LoginResult>();
                if (result?.Success ?? false)
                {
                    result.Message += " Пожалуйста, осуществите вход на сайт.";
                }

                return result;
            }
            return null;
        }        
    }
}
