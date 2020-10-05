using System;

namespace Fruits.Domain.Entities
{
    public class Harvest
    {
        public Guid Id { get; set; }
        public string Information { get; set; }
        public DateTime Date { get; set; }
        public decimal GrossWeight { get; set; }
        public Guid IdTree { get; set; }
        public virtual Tree Tree { get; set; }

        protected Harvest() { }

        public Harvest(string information, DateTime date, decimal grossWeight, Guid idTree)
        {
            Information = information;
            Date = date;
            GrossWeight = grossWeight;
            IdTree = idTree;
        }
    }
}
