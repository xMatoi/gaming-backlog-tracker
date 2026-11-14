using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacklogTracker.Domain;

namespace BacklogTracker.Application.Abstractions
{
    public interface IGameRepository : IRepository<GameEntity, Guid>
    {

        Task<bool> ExistsWithName(string name);

        Task<GameEntity?> GetGameAsync(string nombre);
        Task UpdateName(string name);
    }
}