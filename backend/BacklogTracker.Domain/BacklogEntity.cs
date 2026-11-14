using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacklogTracker.Domain
{
    public class BacklogEntity
    {
        public Guid BacklogId {get; private set;}

        public string ListDescription {get; private set;}


        public ICollection<Backlog_X_Game_Entity> JuegosBacklog { get; private set; } = [];

        public BacklogEntity(string listDescription)
        {
            BacklogId = Guid.NewGuid();
            ListDescription = listDescription;
        }

    }
}