using Fruits.Domain.Entities;
using Fruits.DTO.TreeGroups.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services.Interfaces
{
    public interface ITreeGroupsService
    {
        Task<bool> InsertAsync(TreeGroupInsertRequest request);
        Task<IEnumerable<TreeGroup>> GetAsync();
    }
}
