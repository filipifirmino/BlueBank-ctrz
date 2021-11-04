using BlueBank.Domain.Shared;
using BlueBank.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core
{
    public class CC : Account
    {
        public CC(Guid id, double balance, bool status, Client client) : base(id, balance, status)
        {
            Client = client;
        }

        public Client Client { get; set; }
        public Guid ClintId { get; set; }
    }
}
