using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookShop.Server.Services.AuthService.JwtValidator
{
    public class JwtValidator : ISecurityTokenValidator
    {        
        public bool CanValidateToken => true;
        public int MaximumTokenSizeInBytes { get; set; } = int.MaxValue;       
        public string SecretKey { get; }       

        public JwtValidator(string secretKey)
        {            
            SecretKey = secretKey;
        }        

        public bool CanReadToken(string securityToken) => true;

        public ClaimsPrincipal ValidateToken(string securityToken, TokenValidationParameters validationParameters,
            out SecurityToken validatedToken)
        {
            var jwtTokenHundler = new JwtSecurityTokenHandler();

            try
            {
                if (!string.IsNullOrEmpty(securityToken)
                   && jwtTokenHundler.CanReadToken(securityToken)
                   && jwtTokenHundler.CanValidateToken)
                {
                    var jwtSecurityToken = jwtTokenHundler.ReadJwtToken(securityToken);

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
                            var claimsPrincipal = new ClaimsPrincipal(identity);
                            validatedToken = jwtSecurityToken;
                            return claimsPrincipal;
                        }
                    }
                }
                validatedToken = new JwtSecurityToken();
                return new ClaimsPrincipal();
            }
            catch (Exception)
            {
                validatedToken = new JwtSecurityToken();
                return new ClaimsPrincipal();
            }
        }        
    }
}
