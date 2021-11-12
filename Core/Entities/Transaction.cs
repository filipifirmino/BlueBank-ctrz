using BlueBank.Domain.Shared;
using BlueBank.Domain.Shared.Entitie;
using System;
using System.Collections.Generic;

namespace BlueBank.Domain.Core
{
    public class Transaction : Entity
    {
        public double Value { get; private set; }
        public Guid DestinyClientId { get; set; }
        public Guid AccountId { get; set; }
        public string Type { get; set; }

        public List<Transaction> ToList()
        {
            throw new NotImplementedException();
        }

        public Transaction() : base()
        {

        }

        public Transaction(Guid accountId, Double value, string type) : base()
        {
            AccountId = accountId;
            Value = value;
            Type = type;
        }

        public Transaction(Guid accountId, Double value, Guid destinyClientId, string type) : base()
        {
            AccountId = accountId;
            Value = value;
            DestinyClientId = destinyClientId;
            Type = type;
        }
       
    }

}
