
using BlueBank.Domain.Shared.Entitie;
using BlueBank.Domain.Shared.ValueObjects;
using System;


namespace BlueBank.Domain.Shared
{
    public class Client : Entity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public Guid Id { get; set; }
    }
}
