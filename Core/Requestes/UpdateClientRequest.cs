using BlueBank.Domain.Shared.ValueObjects;
using System;

namespace BlueBank.Domain.Core.Requestes
{
    public class UpdateClientRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
        public Guid Id { get; set; }
    }
}
