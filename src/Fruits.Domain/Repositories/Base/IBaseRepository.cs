using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fruits.Domain.Repositories.Base
{
    public interface IBaseRepository<TModel> where TModel : class
    {
        Task<TModel> GetAsync(Guid id);
        Task<IEnumerable<TModel>> GetAllAsync(Func<IQueryable<TModel>, IQueryable<TModel>> func = null);
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<bool> AddAsync(TModel entity);
        Task<bool> AddRangeAsync(List<TModel> models);
        Task<bool> UpdateAsync(TModel entity);
        Task<bool> UpdateRangeAsync(IEnumerable<TModel> entities);
        Task<bool> RemoveByIdAsync(Guid id);
        Task<bool> RemoveRangeAsync(IEnumerable<TModel> entities);
    }
}
