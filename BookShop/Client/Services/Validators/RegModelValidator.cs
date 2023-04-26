using BookShop.Shared;
using FluentValidation;

namespace BookShop.Client.Services.Validators
{
    public class RegModelValidator : AbstractValidator<IRegModel>
    {
        private readonly IRegModel _regModel;

        public RegModelValidator(IRegModel regModel)
        {
            _regModel = regModel;

            RuleFor(x => x.Email).NotEmpty().WithMessage(StringConsts.EMPTY_EMAIL);
            RuleFor(x => x.Password).NotEmpty().WithMessage(StringConsts.EMPTY_PASSWORD);
            RuleFor(x => x.ConfirmPwd).NotEmpty().WithMessage(StringConsts.EMPTY_CONFIRM_PASSWORD);            
            RuleFor(x => x.Name).NotEmpty().WithMessage(StringConsts.EMPTY_NAME);
            RuleFor(x => x.Surname).NotEmpty().WithMessage(StringConsts.EMPTY_SURNAME);
            RuleFor(x => x.Address).NotEmpty().WithMessage(StringConsts.EMPTY_ADDRESS);
        }
    }
}
