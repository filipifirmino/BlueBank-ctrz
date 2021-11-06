using System;

namespace BlueBank.Domain.Shared
{
    public abstract class Account
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public double Balance { get; set; }
        public bool Status { get; set; }
<<<<<<< HEAD

        protected Account(Guid id, double balance, bool status)
        {
            Id = id;
=======
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        protected Account(Guid id, double balance, bool status)
        {
            this.Id = id;
>>>>>>> context
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Balance = balance;
            Status = status;
        }
    }
}
