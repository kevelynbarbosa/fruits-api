using System;

namespace Fruits.Domain.Entities
{
    public class TreeGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        protected TreeGroup() { }

        public TreeGroup(
            string name,
            string descriptio
            )
        {
            Name = name;
            Description = descriptio;
        }
    }
}
