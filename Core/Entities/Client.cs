
using BlueBank.Domain.Shared.Entitie;
using BlueBank.Domain.Shared.ValueObjects;
using System;

namespace BlueBank.Domain.Core
{
    public class Client : Entity
    {
        public Client(String name, String phone, Address address, string cpf)
        {
            Name = name;
            Phone = phone;
            Address = address;
            Cpf = cpf;
        }

        public Client()
        {

        }
        public Client(String name, String phone, Address address, string cpf, Guid id): base()
        {
            Name = name;
            Phone = phone;
            Address = address;
            Cpf = cpf;
            Id = id;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
    }

    
   
}
