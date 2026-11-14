using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacklogTracker.Application.Abstractions;
using BacklogTracker.Application.DTOs;
using BacklogTracker.Domain;

namespace BacklogTracker.Application.UseCases.GameUseCases
{
    public class UpdateGameUseCase(IRepository<GameEntity, Guid> repository)
    {
        private readonly IRepository<GameEntity, Guid> _repository = repository;

        public async Task<GameEntity> ExecuteAsync(Guid id, UpdateGameDTO dto)
        {
            var game = await _repository.GetByIdAsync(id)
                ?? throw new InvalidOperationException($"No existe un juego con este Id: {id}");

            game.UpdateGame(dto.Name, dto.Description);

            await _repository.UpdateAsync(game);
            await _repository.SaveChanges();

            return game;
        }
    }
}