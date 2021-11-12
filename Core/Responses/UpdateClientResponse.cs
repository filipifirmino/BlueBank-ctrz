using BlueBank.Domain.Shared.Responses;
using BlueBank.Domain.Shared.ValueObjects;
using System;

namespace BlueBank.Domain.Core.Responses
{
    public class UpdateClientResponse : Response
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
    }
}
