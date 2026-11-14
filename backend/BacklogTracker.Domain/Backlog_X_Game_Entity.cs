using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacklogTracker.Domain
{
    public class Backlog_X_Game_Entity
    {
        public Guid BacklogId {get; private set;}
        public BacklogEntity? BacklogEntity{get; private set;}
        public Guid GameId {get; private set;}

        public GameEntity? GameEntity{get; private set;}
        public Guid EstadoId {get; private set;} 

        public EstadoEntity? EstadoEntity {get; private set;}

        public Backlog_X_Game_Entity(Guid backlogId, Guid gameId, Guid estadoId)
        {
            BacklogId = backlogId;
            GameId = gameId;
            EstadoId = estadoId;
        }

        public void UpdateState(Guid newState)
        {
            if (newState == EstadoId)
            {
                throw new InvalidOperationException("Escoja un estado diferente");
            }
        }
    }
}