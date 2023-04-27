using BookShop.Shared;
using FluentValidation;

namespace BookShop.Client.Services.Validators
{
    public class LoginModelValidator : AbstractValidator<ILoginModel>
    {
        private readonly ILoginModel _loginModel;

        public LoginModelValidator(ILoginModel loginModel)
        {
            _loginModel = loginModel;

            RuleFor(x => x.Email).NotEmpty().WithMessage(StringConsts.EMPTY_EMAIL);
            RuleFor(x => x.Password).NotEmpty().WithMessage(StringConsts.EMPTY_PASSWORD);
        }
    }
}
