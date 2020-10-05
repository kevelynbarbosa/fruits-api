using Fruits.Domain.Entities;
using Fruits.Domain.Repositories.Base;
using Fruits.DTO.Harvests.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Repositories
{
    public interface IHarvestsRepository : IBaseRepository<Harvest>
    {
        Task<IEnumerable<Harvest>> GetAsyncFilters(HarvestFiltersRequest request);
    }
}
