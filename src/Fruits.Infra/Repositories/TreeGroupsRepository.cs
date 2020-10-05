using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.Infra.Context;
using Fruits.Infra.Repositories.Base;

namespace Fruits.Infra.Repositories
{
    public class TreeGroupsRepository : BaseRepository<TreeGroup>, ITreeGroupsRepository
    {
        public TreeGroupsRepository(FruitsDbContext context) : base(context) { }
    }
}
