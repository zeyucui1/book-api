using BookManagementSystemAPI.Dto;
using FluentValidation;

namespace BookManagementSystemAPI.Validators
{
    public class BookCreateValidator:AbstractValidator<BookCreateRequest>
    {
        public BookCreateValidator()
        {
            RuleFor(b => b.Name).NotNull().
                WithMessage("Name can not be null").
                NotEmpty().
                WithMessage("Name can not be empty");

            RuleFor(b => b.Description).MaximumLength(20);
        }
    }
}
