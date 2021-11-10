using BlueBank.Domain.Shared.ValueObjects;


namespace BlueBank.Domain.Core.Requestes
{
    public class UpdateClientRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
    }
}
