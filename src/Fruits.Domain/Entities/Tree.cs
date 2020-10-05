using System;

namespace Fruits.Domain.Entities
{
    public class Tree
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public Guid IdTreeSpecie { get; set; }
        public Guid IdTreeGroup { get; set; }
        public virtual TreeGroup TreeGroup { get; set; }
        public virtual TreeSpecie TreeSpecie { get; set; }

        protected Tree() { }

        public Tree(string description, int age, Guid idTreeSpecie, Guid idTreeGroup)
        {
            Description = description;
            Age = age;
            IdTreeSpecie = idTreeSpecie;
            IdTreeGroup = idTreeGroup;
        }
    }
}
