using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacklogTracker.Application.Abstractions;
using BacklogTracker.Domain;
using BacklogTracker.Application.DTOs;

namespace BacklogTracker.Application.UseCases
{
    public class CreateGameUseCase(IRepository<GameEntity, Guid> repository)
    {
        private readonly IRepository<GameEntity, Guid> _repository = repository;

        public async Task<GameEntity> ExecuteAsync(CreateGameDTO dto)
        {
            
            
            
            var game = new GameEntity(dto.GameName, dto.Descripcion);

            await _repository.AddAsync(game);
            await _repository.SaveChanges();
            return game;
        }
    }
}