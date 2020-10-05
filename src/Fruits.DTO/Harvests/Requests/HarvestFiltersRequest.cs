using System;

namespace Fruits.DTO.Harvests.Requests
{
    public class HarvestFiltersRequest
    {
        public Guid? IdTree { get; set; }
        public Guid? IdTreeSpecie { get; set; }
        public Guid? IdTreeGroup { get; set; }
        public DateTime? InitialDate { get; set; }
        public DateTime? FinalDate { get; set; }
    }
}
