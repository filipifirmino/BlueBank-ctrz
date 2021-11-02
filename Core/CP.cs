using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.Domain.Shared;
using BlueBank.Domain.Shared.ValueObjects;

namespace BlueBank.Domain.Core
{
    public class CP : Account
    {
        public CP(Guid id, double balance, bool status, Client client) : base(id, balance, status)
        {
            Client = client;
        }

        public Client Client { get; private set; }
        public Guid ClientId { get; set; }
    }
}
