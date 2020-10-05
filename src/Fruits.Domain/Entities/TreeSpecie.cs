using System;

namespace Fruits.Domain.Entities
{
    public class TreeSpecie
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        protected TreeSpecie() { }

        public TreeSpecie(string description)
        {
            Description = description;
        }
    }
}
