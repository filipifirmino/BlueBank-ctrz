using BlueBank.Domain.Core.Requestes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Validator
{
    public class AddHistoryRequestValidator : AbstractValidator<AddHistoryRequest>
    {
        public AddHistoryRequestValidator()
        {
            RuleFor(x => x.AccountId).NotEmpty().NotNull();
            RuleFor(x => x.CreatedAt).NotEmpty().NotNull();
            RuleFor(x => x.DestinyClient).NotEmpty().NotNull();
            RuleFor(x => x.Value).NotEmpty().NotNull().GreaterThan(0); //conferir notação maior que zero
        }

    }
}
