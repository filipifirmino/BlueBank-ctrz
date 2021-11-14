using BlueBank.Domain.Core.Requestes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Validator
{
    public class WithdrawTransactionValidator: AbstractValidator<AddTransactionWhitdraw>
    {
        public WithdrawTransactionValidator()
        {
            RuleFor(x => x.AccountId).NotEmpty().WithMessage("Informe um Id valido");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Informe um valor valido");
        }
    }
}
