using BookShop.Server.Data;
using BookShop.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookShop.Server.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly DataContext _dataContext;
        private readonly IConfiguration _configuration;       
        

        public AuthService(DataContext dataContext
                         , IConfiguration configuration)
        {
            _dataContext = dataContext;
            _configuration = configuration;            
        }       

        public async Task<LoginResult> LoginAsync(LoginModel loginModel)
        {
            var model = await _dataContext.regModels.FirstOrDefaultAsync(rm => rm.Email.Equals(loginModel.Email));

            if (model == null)
            {
                return new LoginResult
                {
                    Message = "Данный пользователь не зарегистрирован.",
                    Success = false
                };
            }

            if (!BCrypt.Net.BCrypt.Verify(loginModel.Password,model.Password))
            {
                return new LoginResult
                {
                    Message = "Неверный пароль.",
                    Success = false
                };
            }

            string token = CreateToken(model);

            return new LoginResult
            {
                Token = token,
                Success = true,
                Email = model.Email
            };
        }

        public async Task<LoginResult> RegistrationAsync(RegModel regModel)
        {
            if (_dataContext.regModels.Any(x => x.Email == regModel.Email))
            {
                return new LoginResult
                {
                    Message = "Пользователь с данным Email уже существует.",
                    Success = false
                };
            }
            if (regModel.Password != regModel.ConfirmPwd)
            {
                return new LoginResult
                {
                    Message = "Значения паролей не совпадают.",
                    Success = false,
                };
            }

            regModel.Password = BCrypt.Net.BCrypt.HashPassword(regModel.Password);
            regModel.ConfirmPwd = regModel.Password;

            _dataContext.regModels.Add(regModel);
            await _dataContext.SaveChangesAsync();

            return new LoginResult
            {
                Message = "Вы успешно зарегистрировались.",
                Success = true                         
            };
        } 

        private string CreateToken(RegModel regModel)
        {
            List<Claim> claims = new List<Claim> 
            {
                new Claim(ClaimTypes.Name, regModel.Name),
                new Claim(ClaimTypes.Role, regModel.Role.ToString()),
                new Claim(ClaimTypes.Email, regModel.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: cred);          
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }              
    }
}
