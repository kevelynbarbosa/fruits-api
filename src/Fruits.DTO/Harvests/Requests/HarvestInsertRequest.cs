using System;

namespace Fruits.DTO.Harvests.Requests
{
    public class HarvestInsertRequest
    {
        public string Information { get; set; }
        public DateTime Date { get; set; }
        public decimal GrossWeight { get; set; }
        public Guid IdTree { get; set; }
    }
}
