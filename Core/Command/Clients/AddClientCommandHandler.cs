﻿using BlueBank.Domain.Core;
using BlueBank.Domain.Core.Interface;
using BlueBank.Domain.Core.Requestes;

namespace BlueBank.Domain.Shared.Requests
{
    public class AddClientCommandHandler
    {
        private readonly IClientRepository _clientRepository;
        private readonly IAccountRepository _accountRepository;

        public AddClientCommandHandler(IClientRepository repository, IAccountRepository accountRepository)
        {
            _clientRepository = repository;
            _accountRepository = accountRepository;
        }

        public Client Add( AddClientRequest requeste)
        {
            var Client = new Client(requeste.Name, requeste.Phone, requeste.Address, requeste.Cpf);
            var Account = new Account(requeste.TypeAccount, Client);
            Client.Account = Account;
            Client.AccountId = Account.Id;

            _clientRepository.Add(Client);
            _accountRepository.Add(Account);
            _clientRepository.Save();
            _accountRepository.Save();
            
            return Client;
        }
    }
}