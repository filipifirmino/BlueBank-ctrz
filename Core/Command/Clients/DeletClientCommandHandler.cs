
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Shared.Entitie.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Command.Client
{
    public class DeletClientCommandHandler
    {
        private readonly IClientRepository _clientRepository;
        private readonly IAccountRepository _accountRepository;

        public DeletClientCommandHandler(IClientRepository repository, IAccountRepository accountRepository)
        {
            _clientRepository = repository;
            _accountRepository = accountRepository;
        }

        public void Delete(Guid id)
        {
            var cliente = _clientRepository.GetById(id);
            var account = _accountRepository.GetById(cliente.AccountId);
            
                if (account.Balance == 0)
                {
                    _clientRepository.Remove(cliente);
                    _accountRepository.Remove(account);
                    _accountRepository.Save();
                    _clientRepository.Save();
                }
                else
                {
                    throw new DomainException("Saldo da conta diferente de 0");
                }     

        }
    }
}
