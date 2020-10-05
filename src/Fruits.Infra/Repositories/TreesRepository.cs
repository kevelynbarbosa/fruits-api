using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.Infra.Context;
using Fruits.Infra.Repositories.Base;

namespace Fruits.Infra.Repositories
{
    public class TreesRepository : BaseRepository<Tree>, ITreesRepository
    {
        public TreesRepository(FruitsDbContext context) : base(context) { }
    }
}
