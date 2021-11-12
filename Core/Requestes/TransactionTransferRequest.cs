using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Requestes
{
    public class TransactionTransferRequest
    {
        public Guid AccountId { get; set; }
        public double Value { get; set; }
        public Guid AccountDestinyId { get; set; }
    }
}
