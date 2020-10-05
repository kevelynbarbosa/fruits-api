using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.TreeSpecies.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services
{
    public class TreeSpeciesService : ITreeSpeciesService
    {
        private readonly ITreeSpeciesRepository _treeSpeciesRepository;

        public TreeSpeciesService(ITreeSpeciesRepository treeSpeciesRepository)
        {
            _treeSpeciesRepository = treeSpeciesRepository;
        }

        public async Task<bool> InsertAsync(TreeSpecieInsertRequest request)
        {
            var specie = new TreeSpecie(request.Description);

            await _treeSpeciesRepository.AddAsync(specie);

            return true;
        }

        public async Task<IEnumerable<TreeSpecie>> GetAsync()
        {
            var species = await _treeSpeciesRepository.GetAllAsync();

            return species;
        }
    }
}
