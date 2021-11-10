
using BlueBank.Domain.Shared;
using BlueBank.Domain.Shared.Entitie;
using System;
using System.Collections.Generic;


namespace BlueBank.Domain.Core
{
    public class Account : Entity
    {
   
        public List<Transaction> Transactions { get; set; }
        public double Balance { get; set; }
        public bool Status { get; set; }
        public AccountType Type { get; set; }
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        public Account(AccountType type, Client client)
        {
            Transactions = new List<Transaction>();
            Status = true;
            Balance = 0.0;
            Type = type;
            Client = client;
            ClientId = client.Id;
        }
    }
}
