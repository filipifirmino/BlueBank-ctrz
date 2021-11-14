using System;


namespace BlueBank.Domain.Shared.Entitie.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
