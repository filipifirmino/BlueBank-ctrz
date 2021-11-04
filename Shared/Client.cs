using BlueBank.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core
{
    public class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Cpf { get; set; }
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
   }
}
