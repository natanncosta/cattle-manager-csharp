using CattleManager.Domain.Interfaces;
using CattleManager.Domain.Models;

namespace CattleManager.Services;

public class TerrainService : ITerrainService
{
    private readonly IRepository<Terrain> _repository;

    public TerrainService(IRepository<Terrain> repository)
        => _repository = repository;

    public Terrain Add(Terrain terrain)
    {
        _repository.Save(terrain);
        return terrain;
    }
}
