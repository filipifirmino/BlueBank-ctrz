using System;

namespace BlueBank.Domain.Shared.Entitie
{
    public class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

    }
}
