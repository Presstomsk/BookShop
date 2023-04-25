using Blazored.LocalStorage;
using BookShop.Client.Services.AuthService;
using BookShop.Client.Services.StatsService;
using BookShop.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
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
        private readonly IStatsService _statsService;

        public CustomAuthStateProvider(ILocalStorageService localStorage
                                     , IAuthService authService 
                                     , IStatsService statsService)
        {
            _localStorage = localStorage;
            _authService = authService;
            _statsService = statsService;            
        }

        public async Task<string> GetTokenAsync()
        {
            return await _localStorage.GetItemAsync<string>("token");
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var state = new AuthenticationState(new ClaimsPrincipal());
            var token = await GetTokenAsync();            
            var jwtTokenHundler = new JwtSecurityTokenHandler();          

            if (!string.IsNullOrEmpty(token)
               && jwtTokenHundler.CanReadToken(token)
               && jwtTokenHundler.CanValidateToken)
            {
                var jwtSecurityToken = jwtTokenHundler.ReadJwtToken(token);                               

                if (jwtSecurityToken != null && jwtSecurityToken.ValidTo > DateTime.UtcNow)
                {                    
                    var userName = jwtSecurityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
                    var userRole = jwtSecurityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
                    var userEmail = jwtSecurityToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;

                    if (!string.IsNullOrEmpty(userName) 
                        && !string.IsNullOrEmpty(userRole) 
                        && !string.IsNullOrEmpty(userEmail))
                    {
                        var identity = new ClaimsIdentity(new[]
                        {
                            new Claim(ClaimTypes.Name, userName),
                            new Claim(ClaimTypes.Role, userRole)
                        }, "authenticated type");
                        state = new AuthenticationState(new ClaimsPrincipal(identity));

                        await _statsService.IncrementVisitsAsync(userEmail);
                    }                   
                }
                else
                {
                    await _localStorage.RemoveItemAsync("token");
                }
            }

            NotifyAuthenticationStateChanged(Task.FromResult(state));
            return state;
        }
    }
}
