using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BacklogTracker.Application.Abstractions;
using BacklogTracker.Domain;

namespace BacklogTracker.Application.UseCases
{
    public class GetGameByNameUseCase(IGameRepository repository)
    {
        private readonly IGameRepository _repository = repository;

        public async Task<GameEntity> ExecuteAsync(string name)
        {
            var game = await _repository.GetGameAsync(name)
                ?? throw new InvalidOperationException($"No se encontró el juego: {name}");

            return game;
        }
    }
}