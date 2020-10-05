using Fruits.Domain.Entities;
using Fruits.DTO.Harvests.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services.Interfaces
{
    public interface IHarvestsService
    {
        Task<bool> InsertAsync(HarvestInsertRequest request);
        Task<IEnumerable<Harvest>> GetAsync(HarvestFiltersRequest request);
    }
}
