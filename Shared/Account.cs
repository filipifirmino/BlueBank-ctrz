using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Shared
{
    public abstract class Account
    {
        public Guid id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public double Balance { get; set; }
        public bool Status { get; set; }
    }
}
