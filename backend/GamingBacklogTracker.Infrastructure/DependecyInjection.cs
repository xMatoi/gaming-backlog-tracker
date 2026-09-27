using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GamingBacklogTracker.Application.Interfaces;
using GamingBacklogTracker.Infrastructure.Data;
using GamingBacklogTracker.Infrastructure.Repositories;

namespace GamingBacklogTracker.Infrastructure;

public static class DependencyInjection {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString) {
        
        // 1. Configuramos el acceso a PostgreSQL
        services.AddDbContext<GamingBacklogTrackerDbContext>(options =>
            options.UseNpgsql(connectionString));

        // 2. LA INYECCIÓN CLAVE (El contrato firmado por el Gerente):
        // "Cada vez que un Chef (Controlador) pida la Receta (IHabitoRepository), 
        // entrégale los datos de la Finca PostgreSQL (HabitoRepository)"
        services.AddScoped<IGamingRepository, GamingRepository>();

        return services;
    }
}
