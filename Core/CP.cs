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
        public CP(Guid id, double balance, bool status, string type) : base(id, balance, status)
        {
            Type = type;
        }

        public string Type { get; set; }
    }
}
