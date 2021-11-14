using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;
using BlueBank.Domain.Shared.Entitie.Exceptions;
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
        private readonly IAccountRepository _accountRepository;

        public WithdrawCommandHandler(ITransactionRepository repository, IAccountRepository accountRepository)
        {
            _itransactionRepository = repository;
            _accountRepository = accountRepository;
        }

        public void Withdraw(AddTransactionWhitdraw request)
        {
            var account = _accountRepository.GetById(request.AccountId);
            if(request.Value < account.Balance)
            {
                account.Balance -= request.Value;
            }
            else
            {
               throw new DomainException($"Saldo insuficiente {account.Balance}");
            }
            _accountRepository.Update(account);
            _accountRepository.Save();
            _itransactionRepository.Withdraw(request.AccountId, request.Value);
            _itransactionRepository.Save();
        }
    }
}
