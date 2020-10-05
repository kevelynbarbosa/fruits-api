using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.TreeGroups.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services
{
    public class TreeGroupsService : ITreeGroupsService
    {
        private readonly ITreeGroupsRepository _treeGroupsRepository;

        public TreeGroupsService(ITreeGroupsRepository treeGroupsRepository)
        {
            _treeGroupsRepository = treeGroupsRepository;
        }

        public async Task<bool> InsertAsync(TreeGroupInsertRequest request)
        {
            var group = new TreeGroup(request.Name, request.Description);

            await _treeGroupsRepository.AddAsync(group);

            return true;
        }

        public async Task<IEnumerable<TreeGroup>> GetAsync()
        {
            var groups = await _treeGroupsRepository.GetAllAsync();

            return groups;
        }
    }
}
