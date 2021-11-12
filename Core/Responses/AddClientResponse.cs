using BlueBank.Domain.Shared;
using BlueBank.Domain.Shared.Responses;
using BlueBank.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Core.Responses
{
    public class AddClientResponse : Response
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
        public AccountType TypeAccount { get; set; }
    }
}
