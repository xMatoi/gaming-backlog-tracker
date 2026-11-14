using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacklogTracker.Application.DTOs
{
    public class CreateGameDTO
    {
        public string GameName {get; set;} = string.Empty;
        public string Descripcion {get; set;} = string.Empty;

    }
}