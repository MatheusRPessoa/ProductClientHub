using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator
{
    public class RequestProductValidator : AbstractValidator<RequestProductJson>
    {
        public RequestProductValidator()
        {
            RuleFor(product => product.Name).NotEmpty().WithMessage("O nome não pode ser vazio.");
            RuleFor(product => product.Brand).NotEmpty().WithMessage("A marca não pode ser vazio.");
            RuleFor(product => product.Price).GreaterThan(0).WithMessage("O preço deve ser maior que zero.");
        }
    }
}
