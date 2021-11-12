
using BlueBank.Domain.Core.Interface;
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
            _clientRepository.Remove(cliente);
            _accountRepository.Remove(cliente.Account);
        }
    }
}
