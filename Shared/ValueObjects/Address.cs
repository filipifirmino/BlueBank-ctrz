using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.Domain.Shared.ValueObjects
{
    public class Address : ValueObject
     {
        public string Street { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Cpf { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string phone, string state, string cpf, string zipCode)
        {
            Street = street;
            Phone = phone;
            State = state;
            Cpf = cpf;
            ZipCode = zipCode;
        }
    }

    public class ValueObject
    {
    }
}
