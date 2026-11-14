using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacklogTracker.Domain;

namespace BacklogTracker.Application.Abstractions
{
    public interface IBacklogRepository<TEntity, Guid> where TEntity : class
    {
       Task AddAsync(BacklogEntity backlogEntity);

        
    }
}