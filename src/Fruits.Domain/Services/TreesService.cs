using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.Domain.Services.Interfaces;
using Fruits.DTO.Trees.Requests;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fruits.Domain.Services
{
    public class TreesService : ITreesService
    {
        private readonly ITreesRepository _treesRepository;

        public TreesService(ITreesRepository treesRepository)
        {
            _treesRepository = treesRepository;
        }

        public async Task<bool> InsertAsync(TreeInsertRequest request)
        {
            var tree = new Tree(request.Description, request.Age, request.IdTreeSpecie, request.IdTreeGroup);

            await _treesRepository.AddAsync(tree);

            return true;
        }

        public async Task<IEnumerable<Tree>> GetAsync()
        {
            var trees = await _treesRepository.GetAllAsync();

            return trees;
        }
    }
}
