using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Command.Transaction
{
    public class DepositCommandHandler
    {
        private readonly ITransactionRepository _itransactionRepository;

        public DepositCommandHandler(ITransactionRepository repository)
        {
            _itransactionRepository = repository;
        }
        public Guid Deposit(AddTransctionDeposit request)
        {
            var result = _itransactionRepository.Deposit(request.AccountId, request.Value);
            _itransactionRepository.Save();
            return result;
        }
    }
}
