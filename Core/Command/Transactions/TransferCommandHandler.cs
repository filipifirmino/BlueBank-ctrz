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
    public class TransferCommandHandler
    {
        private readonly ITransactionRepository _itransactionRepository;
        private readonly IAccountRepository _accountRepository;

        public TransferCommandHandler(ITransactionRepository repository,IAccountRepository accountRepository)
        {
            _itransactionRepository = repository;
            _accountRepository = accountRepository;
        }

        public void Transfer(TransactionTransferRequest request)
        {
            var account = _accountRepository.GetById(request.AccountId);
            var destinyAccount = _accountRepository.GetById(request.AccountDestinyId);

            if (account.Balance > request.Value)
            {
                destinyAccount.Balance += request.Value;
                account.Balance -= request.Value;
            }
            else
            {
                throw new DomainException($"Saldo insuficiente {account.Balance}");
            }

            _accountRepository.Update(account);
            _accountRepository.Update(destinyAccount);
            _accountRepository.Save();
            _itransactionRepository.Transfer(request.AccountId, request.Value, request.AccountDestinyId);
            _itransactionRepository.Save();
        }
    }
}
