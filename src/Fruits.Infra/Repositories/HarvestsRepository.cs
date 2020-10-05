using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.DTO.Harvests.Requests;
using Fruits.Infra.Context;
using Fruits.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fruits.Infra.Repositories
{
    public class HarvestsRepository : BaseRepository<Harvest>, IHarvestsRepository
    {
        public HarvestsRepository(FruitsDbContext context) : base(context) { }

        public async Task<IEnumerable<Harvest>> GetAsyncFilters(HarvestFiltersRequest request)
        {
            var query = DatabaseContext.Set<Harvest>()
                .OrderByDescending(x => x.Date)
                .AsQueryable();

            if (request.IdTree.HasValue)
                query = query.Where(x => x.IdTree == request.IdTree.Value);

            if (request.IdTreeSpecie.HasValue)
                query = query.Where(x => x.Tree.IdTreeSpecie == request.IdTreeSpecie.Value);

            if (request.IdTreeGroup.HasValue)
                query = query.Where(x => x.Tree.IdTreeGroup == request.IdTreeGroup.Value);

            if (request.InitialDate.HasValue)
                query = query.Where(x => x.Date >= request.InitialDate.Value);

            if (request.FinalDate.HasValue)
                query = query.Where(x => x.Date <= request.FinalDate.Value);

            var harvests = await query.ToListAsync();

            return harvests;
        }
    }
}
