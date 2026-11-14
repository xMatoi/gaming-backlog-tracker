using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacklogTracker.Application.Abstractions;
using BacklogTracker.Domain;

namespace BacklogTracker.Application.UseCases.GameUseCases
{
    public class GetAllGamesUseCase(IRepository <GameEntity, Guid> repository)
    {
        private readonly IRepository<GameEntity, Guid> _repository = repository;


        public async Task<IEnumerable<GameEntity>> ExecuteAsync(){

            return await _repository.GetAllAsync();
        }
    }
}