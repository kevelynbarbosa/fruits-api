using System;

namespace Fruits.DTO.Trees.Requests
{
    public class TreeInsertRequest
    {
        public string Description { get; set; }
        public int Age { get; set; }
        public Guid IdTreeSpecie { get; set; }
        public Guid IdTreeGroup { get; set; }
    }
}
