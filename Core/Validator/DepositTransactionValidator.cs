using BlueBank.Domain.Core.Requestes;
using FluentValidation;

namespace BlueBank.Domain.Core.Validator
{
    public class DepositTransactionValidator: AbstractValidator<AddTransctionDeposit>
    {
        public DepositTransactionValidator()
        {
            RuleFor(x => x.AccountId).NotEmpty().WithMessage("Informe um Id de conta valido");
            RuleFor(x => x.Value).NotEmpty().NotEqual(0).WithMessage("informe um valor valido");
        }
    }
}
