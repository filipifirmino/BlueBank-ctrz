using System;

namespace BlueBank.Domain.Shared.Entitie
{
    public class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

    }
}
