using System;

namespace CaixaEletronico.Entities
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            var now = DateTime.Now;
            CreatedAt = now;
            UpdatedAt = now;
        }

        public DateTime CreatedAt { get; set; }
        public Guid Id { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}