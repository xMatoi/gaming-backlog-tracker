using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacklogTracker.Application.Abstractions;
using BacklogTracker.Domain;

namespace BacklogTracker.Application.UseCases
{
    public class DeleteGameUseCase(IRepository<GameEntity, Guid> repository)
    {
        private readonly IRepository<GameEntity, Guid> _repository = repository;

        public async Task ExecuteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
            await _repository.SaveChanges();
        }
    }
}