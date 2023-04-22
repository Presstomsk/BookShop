using Blazored.LocalStorage;
using BookShop.Client.Services.AuthService;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using static System.Net.WebRequestMethods;

namespace BookShop.Client
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly ILocalStorageService _localStorage;
        private readonly IAuthService _authService;
        private readonly HttpClient _httpClient;

        public CustomAuthStateProvider(ILocalStorageService localStorage, IAuthService authService , HttpClient httpClient)
        {
            _localStorage = localStorage;
            _authService = authService;
            _httpClient = httpClient;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            var token = await _localStorage.GetItemAsStringAsync("token");
            var name = await _localStorage.GetItemAsStringAsync("name");            
           
            if (!string.IsNullOrEmpty(token) && !string.IsNullOrEmpty(name))                
            {
                var identity = new ClaimsIdentity(new[]
                     {
                        new Claim(ClaimTypes.Name, name)
                    }, "authenticated type");
                state = new AuthenticationState(new ClaimsPrincipal(identity));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
        }
    }
}
