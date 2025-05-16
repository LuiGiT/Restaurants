using FluentValidation;
using Restaurants.Application.Restaurants.Commands.CreateRestaurant;

namespace Restaurants.Application.Restaurants.Validators
{
    public class CreateRestaurantCommandValidator : AbstractValidator<CreateRestaurantCommand>
    {
        private readonly List<string> validCategories = ["Italian", "Mexican", "Japanse", "American", "Indian"];
        public CreateRestaurantCommandValidator()
        {
            RuleFor(dto => dto.Name)
                .Length(3, 100);

            RuleFor(dto => dto.Description)
                .NotEmpty().WithMessage("Description is required");

            RuleFor(dto => dto.Category)
                .Must(validCategories.Contains)
                .WithMessage("Invalid Category, Please choose a validd one");

            RuleFor(dto => dto.ContactEmail)
                .EmailAddress().WithMessage("Please provide a valid email");
        }
    }
}
