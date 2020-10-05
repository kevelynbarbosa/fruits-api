using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.Harvests.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services
{
    public class HarvestsService : IHarvestsService
    {
        private readonly IHarvestsRepository _harvestsRepository;

        public HarvestsService(IHarvestsRepository harvestsRepository)
        {
            _harvestsRepository = harvestsRepository;
        }

        public async Task<bool> InsertAsync(HarvestInsertRequest request)
        {
            var harvest = new Harvest(request.Information, request.Date, request.GrossWeight, request.IdTree);

            await _harvestsRepository.AddAsync(harvest);

            return true;
        }

        public async Task<IEnumerable<Harvest>> GetAsync(HarvestFiltersRequest request)
        {
            var harvests = await _harvestsRepository.GetAsyncFilters(request);

            return harvests;
        }
    }
}
