using Fruits.Domain.Entities;
using Fruits.Domain.Repositories;
using Fruits.Infra.Context;
using Fruits.Infra.Repositories.Base;

namespace Fruits.Infra.Repositories
{
    public class TreeSpeciesRepository : BaseRepository<TreeSpecie>, ITreeSpeciesRepository
    {
        public TreeSpeciesRepository(FruitsDbContext context) : base(context) { }
    }
}
