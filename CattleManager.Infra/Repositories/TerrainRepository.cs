using CattleManager.Domain.Models;
using CattleManager.Domain.Interfaces;
using CattleManager.Infra.Context;

namespace CattleManager.Infra.Repositories;

public class TerrainRepository : ITerrainRepository
{
    protected readonly AppDbContext _context;

    public TerrainRepository(AppDbContext context)
    { _context = context; }

    public IEnumerable<Terrain> GetAll()
    {
        var query = _context.Set<Terrain>();
        if (query.Any())
            return query.ToList();
        return new List<Terrain>();
    }

    public Terrain GetById(int id)
    {
        var query = _context.Set<Terrain>().Where(x => x.Id == id);
        if (query.Any())
            return query.FirstOrDefault()!;
        return null!;
    }

    public void Save(Terrain entity)
    {
        _context.Set<Terrain>().Add(entity);
        _context.SaveChangesAsync();
    }

    public Terrain GetByName(string description)
    {
        var query = _context.Set<Terrain>()
                            .Where(t => t.Description == description);
        if (query.Any())
            return query.FirstOrDefault()!;
        return null!;
    }
}
