namespace BacklogTracker.Domain;

public class GameEntity
{
    public Guid GameId { get; private set; } = Guid.NewGuid();
    public string NombreJuego { get; private set; } = string.Empty;
    public string Descripcion { get; private set; } = string.Empty;

    public ICollection<Backlog_X_Game_Entity> JuegosBacklog { get; private set; } = [];

    public GameEntity(string nombreJuego, string descripcion)
    {
        ValidateName(nombreJuego);
        ValidateDescription(descripcion);

        NombreJuego = nombreJuego.Trim();
        Descripcion = descripcion;
    }


    public void UpdateGame(string? nombre, string? desc)
        {
            if (!string.IsNullOrWhiteSpace(nombre))
            {
                NombreJuego = nombre;
            }
            if (!string.IsNullOrWhiteSpace(desc))
            {
                Descripcion = desc;
            }

        }
    public void ValidateName(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre del juego no puede ir vacío");
        }

        if (nombre.Length < 3)
        {
            throw new ArgumentException($"El nombre {nombre} es muy corto");
        }

        if (nombre.Length > 40)
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

        if (desc.Length < 3)
        {
            throw new ArgumentException($"La descripción {desc} es muy corta");
        }

        if (desc.Length > 200)
        {
            throw new ArgumentException($"La descripción {desc} es muy larga");
        }
    }

}
