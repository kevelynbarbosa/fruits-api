using Fruits.Domain.Entities;
using Fruits.DTO.Trees.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services.Interfaces
{
    public interface ITreesService
    {
        Task<bool> InsertAsync(TreeInsertRequest request);
        Task<IEnumerable<Tree>> GetAsync();
    }
}
