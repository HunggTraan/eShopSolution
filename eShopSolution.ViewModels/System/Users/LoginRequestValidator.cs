using FluentValidation;

namespace eShopSolution.ViewModels.System.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username is required!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required!")
                .MinimumLength(8).WithMessage("Password needs at least 8 characters");
        }
    }
}