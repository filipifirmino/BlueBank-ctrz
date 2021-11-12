using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Command.Transaction
{
    public class WithdrawCommandHandler
    {
        private readonly ITransactionRepository _itransactionRepository;

        public WithdrawCommandHandler(ITransactionRepository repository)
        {
            _itransactionRepository = repository;
        }

        public void Withdraw(AddTransactionWhitdraw request)
        {
            _itransactionRepository.Withdraw(request.AccountId, request.Value);
            _itransactionRepository.Save();
        }
    }
}
