using BlueBank.Domain.Core;
using BlueBank.Domain.Shared.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Shared
{
    public class Account : Entity
    {
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public List<Transaction> Transactions { get; set; }
        public double Balance { get; set; }
        public bool Status { get; set; }
        public AccountType Type { get; set; }
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        public Account()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Transactions = new List<Transaction>();
            Status = true;
        }
    }
}
