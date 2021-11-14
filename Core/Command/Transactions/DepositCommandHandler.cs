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
        private readonly IAccountRepository _accountRepository;

        public DepositCommandHandler(ITransactionRepository repository, IAccountRepository accountRepository)
        {
            _itransactionRepository = repository;
            _accountRepository = accountRepository;
        }
        public Guid Deposit(AddTransctionDeposit request)
        {
            var result = _itransactionRepository.Deposit(request.AccountId, request.Value);
            var account = _accountRepository.GetById(request.AccountId);
            account.Balance += request.Value;

            _accountRepository.Update(account);

            _accountRepository.Save();
            _itransactionRepository.Save();
            
            return result;
        }
    }
}
