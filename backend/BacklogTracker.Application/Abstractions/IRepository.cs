using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacklogTracker.Application.Abstractions
{
    public interface IRepository<TEntity, TId> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity?> GetByIdAsync(TId id);

        Task AddAsync(TEntity entity);
        Task DeleteAsync(TId id);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<int> SaveChanges();
    }
}