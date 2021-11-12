using BlueBank.Domain.Core.Requestes;
using FluentValidation;

namespace BlueBank.Domain.Core.Validator
{
    public class AddClientRequestValidator : AbstractValidator<AddClientRequest>
    {
        public AddClientRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Phone).NotEmpty().NotNull();
            RuleFor(x => x.Cpf).NotEmpty().NotNull();
            RuleFor(x => x.TypeAccount).NotNull();
        }
    }
}
