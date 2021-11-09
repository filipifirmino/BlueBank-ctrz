
using BlueBank.Domain.Shared.Entitie;
using BlueBank.Domain.Shared.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueBank.Domain.Core
{
    public class Client : Entity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
        [NotMapped]
        //public Account Account { get; set; }
        public Guid AccountId { get; set; }
    }
}
