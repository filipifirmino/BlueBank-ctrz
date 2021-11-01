using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlueBank.Domain.Shared;
using BlueBank.Domain.Shared.ValueObjects;

namespace BlueBank.Domain.Core
{
    class CP : Account
    {
        public Client Client { get; set; }
    }
}
