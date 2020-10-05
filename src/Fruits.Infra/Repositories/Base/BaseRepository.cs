using Fruits.Domain.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fruits.Infra.Repositories.Base
{
    public abstract class BaseRepository<TModel> : IBaseRepository<TModel> where TModel : class
    {
        protected readonly DbContext DatabaseContext;

        public BaseRepository(DbContext context)
        {
            DatabaseContext = context;
        }

        public async Task<bool> AddAsync(TModel entity)
        {
            await DatabaseContext.Set<TModel>().AddAsync(entity);
            var returnValue = await DatabaseContext.SaveChangesAsync();
            return returnValue > 0;
        }

        public async Task<bool> AddRangeAsync(List<TModel> models)
        {
            await DatabaseContext.Set<TModel>().AddRangeAsync(models);

            var returnValue = await DatabaseContext.SaveChangesAsync();

            return returnValue > 0;
        }

        public async Task<TModel> GetAsync(Guid id)
        {
            return await DatabaseContext.Set<TModel>().FindAsync(id);
        }

        public async Task<bool> UpdateAsync(TModel entity)
        {
            DatabaseContext.Set<TModel>().Update(entity);

            var returnValue = await DatabaseContext.SaveChangesAsync();

            return returnValue > 0;
        }

        public async Task<bool> UpdateRangeAsync(IEnumerable<TModel> entities)
        {
            DatabaseContext.Set<TModel>().UpdateRange(entities);

            var returnValue = await DatabaseContext.SaveChangesAsync();

            return returnValue > 0;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync(Func<IQueryable<TModel>, IQueryable<TModel>> func = null)
        {
            var dbSet = DatabaseContext.Set<TModel>();

            if (func != null)
            {
                return await func(dbSet)
                    .ToListAsync();
            }

            return await dbSet.ToListAsync();
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            return await DatabaseContext.Set<TModel>()
                .ToListAsync();
        }


        public async Task<bool> RemoveByIdAsync(Guid id)
        {
            var existingEntity = DatabaseContext.Set<TModel>().FindAsync(id);
            DatabaseContext.Remove(existingEntity);
            var returnValue = await DatabaseContext.SaveChangesAsync();
            return returnValue > 0;
        }

        public async Task<bool> RemoveRangeAsync(IEnumerable<TModel> entities)
        {
            DatabaseContext.RemoveRange(entities);
            var returnValue = await DatabaseContext.SaveChangesAsync();
            return returnValue > 0;
        }
    }
}
