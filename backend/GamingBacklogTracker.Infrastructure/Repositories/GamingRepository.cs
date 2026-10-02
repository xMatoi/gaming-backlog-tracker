using GamingBacklogTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

using GamingBacklogTracker.Application.Interfaces;

using GamingBacklogTracker.Infrastructure.Data;

namespace GamingBacklogTracker.Infrastructure.Repositories;


public class GamingRepository : IGamingRepository {
    private readonly GamingBacklogTrackerDbContext _context;
    
    // El constructor recibe el contexto de EF Core
    public GamingRepository(GamingBacklogTrackerDbContext context) {
        _context = context;
    }

    public async Task<IEnumerable<GamingGlobal>> GetAllAsync() {
        return await _context.JuegosGlobales.ToListAsync(); // Consulta real a BD (Magia SQL)
    }

    public async Task<GamingGlobal> AddAsync(GamingGlobal habito) {
        await _context.JuegosGlobales.AddAsync(habito);
         await _context.SaveChangesAsync(); 
        
        return habito;
}
}