using Microsoft.EntityFrameworkCore;
using GamingBacklogTracker.Domain.Entities;

namespace GamingBacklogTracker.Infrastructure.Data;

public class GamingBacklogTrackerDbContext : DbContext {
    public GamingBacklogTrackerDbContext(DbContextOptions<GamingBacklogTrackerDbContext> options) : base(options) { }
    
    public DbSet<GamingGlobal> JuegosGlobales { get; set; }
}
