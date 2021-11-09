using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Requestes
{
     public  class AddHistoryRequest
    {
        public DateTime CreatedAt { get; private set; }
        public double Value { get; private set; }
        public Client DestinyClient { get; set; }
        public Guid AccountId { get; set; }
    }
}
