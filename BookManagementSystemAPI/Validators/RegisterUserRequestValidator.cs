using BookManagementSystemAPI.Dto;
using FluentValidation;

namespace BookManagementSystemAPI.Validators
{
    /// <summary>
    /// 
    /// </summary>
    public class RegisterUserRequestValidator: AbstractValidator<RegisterRequestDto>
    {
        /// <summary>
        /// 
        /// </summary>
        public RegisterUserRequestValidator()
        {
            RuleFor(x => x.Email).EmailAddress().NotEmpty().NotNull();
            RuleFor(x => x.Password).NotEmpty().NotNull();
            RuleFor(x => x.FullName).NotEmpty().NotNull();
        }
    }
}
