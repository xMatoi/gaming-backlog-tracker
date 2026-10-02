using GamingBacklogTracker.Domain.Entities;

namespace GamingBacklogTracker.Application.Interfaces;

public interface IGamingRepository {
    Task<IEnumerable<GamingGlobal>> GetAllAsync();
    Task<GamingGlobal> AddAsync(GamingGlobal habito);
}
