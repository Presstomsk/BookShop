using BookShop.Shared;
using FluentValidation;

namespace BookShop.Client.Services.Validators
{
    public class ExtendedProductValidator : AbstractValidator<IExtendedProduct>
    {
        private readonly IExtendedProduct _extendedProduct;

        public ExtendedProductValidator(IExtendedProduct extendedProduct)
        {
            _extendedProduct = extendedProduct;

            RuleFor(x => x.Title).NotEmpty().WithMessage(StringConsts.EMPTY_TITLE);
            RuleFor(x => x.Description).NotEmpty().WithMessage(StringConsts.EMPTY_DESCRIPTION);
            RuleFor(x => x.Image).NotEmpty().WithMessage(StringConsts.EMPTY_IMAGE);
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage(StringConsts.EMPTY_CATEGORY_NAME);
            RuleFor(x => x.EditionName).NotEmpty().WithMessage(StringConsts.EMPTY_EDITION_NAME);
            RuleFor(x => x.OriginalPrice).NotEmpty().WithMessage(StringConsts.EMPTY_ORIGINAL_PRICE);
            RuleFor(x => x.Price).NotEmpty().WithMessage(StringConsts.EMPTY_PRICE);
        }
    }
}
