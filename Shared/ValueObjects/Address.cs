namespace BlueBank.Domain.Shared.ValueObjects
{
    public class Address : ValueObject
    {
        public string Street { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address(string street, string state, string zipCode)
        {
            Street = street;
            State = state;
            ZipCode = zipCode;
        }

        public Address()
        {

        }

        public Address(string fullAddress)
        {
            SetFrom(fullAddress);
        }

        public void SetFrom(string fullAddress)
        {
            var address = fullAddress.Split(",");

            Street = address[0];
            State = address[1];
            ZipCode = address[2];
        }


        public string FullAddress => GetBy();

        public string GetBy()
        {
            return $"{Street}, {State}, {ZipCode}";
        }
    }



    public class ValueObject
    {
    }
}
