using BlueBank.Domain.Core.Requestes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Validator
{
    public class TransferTransactionValidator : AbstractValidator<TransactionTransferRequest>
    {
        public TransferTransactionValidator()
        {
            RuleFor(x => x.AccountId).NotEmpty().WithMessage("Informe um Id de conta valido");
            RuleFor(x => x.AccountDestinyId).NotEmpty().WithMessage("Informe um Id de conta valido");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Informe um valor valido");
        }
    }
}
