using System;


namespace BlueBank.Domain.Shared
{
    public class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Cpf { get; set; }
        // public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public Guid Id { get; set; }
   }
}
