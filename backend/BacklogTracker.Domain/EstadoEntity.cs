using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacklogTracker.Domain
{
    public class EstadoEntity
    {
        public Guid EstadoId{get; private set;}
        
        public string NombreEstado {get; private set;} = string.Empty;

        public string Descripcion {get; private set;} = string.Empty;

        public ICollection<Backlog_X_Game_Entity> JuegosBacklog { get; private set; } = [];


         public void UpdateDescription(string? desc)
        {
            if (!string.IsNullOrWhiteSpace(desc))
            {
                Descripcion = desc;
            }

        }
        public EstadoEntity(string nombreEstado, string descripcion)
        {
            ValidateName(nombreEstado);
            ValidateDescription(descripcion);

            EstadoId = Guid.NewGuid();
            NombreEstado = nombreEstado;
            Descripcion = descripcion;
        }

        public void ValidateName(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre de la descripción no puede ir vacío");
        }

        if (nombre.Length > 15)
        {
            throw new ArgumentException($"El nombre {nombre} es muy largo");
        }
    }

    public void ValidateDescription(string desc)
    {
         if (string.IsNullOrWhiteSpace(desc))
        {
            throw new ArgumentException("El nombre del juego no puede ir vacío");
        }

        if (desc.Length > 200)
        {
            throw new ArgumentException($"La descripción {desc} es muy larga");
        }
    }

    }
}