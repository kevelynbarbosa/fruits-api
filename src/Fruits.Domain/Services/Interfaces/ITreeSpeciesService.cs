using Fruits.Domain.Entities;
using Fruits.DTO.TreeSpecies.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services.Interfaces
{
    public interface ITreeSpeciesService
    {
        Task<bool> InsertAsync(TreeSpecieInsertRequest request);
        Task<IEnumerable<TreeSpecie>> GetAsync();
    }
}
