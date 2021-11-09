using BlueBank.Domain.Shared;
using BlueBank.Domain.Shared.Entitie;
using System;
using System.Collections.Generic;

namespace BlueBank.Domain.Core
{
    public class Transaction : Entity
    {
        public DateTime CreatedAt { get; private set; }
        public double Value { get; private set; }
        public Client DestinyClient { get; set; }
        public Guid AccountId { get; set; }

        public List<Transaction> ToList()
        {
            throw new NotImplementedException();
        }
    }

}
