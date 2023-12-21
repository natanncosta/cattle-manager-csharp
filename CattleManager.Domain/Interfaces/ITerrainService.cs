using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface ITerrainService
{
    public Terrain Add(Terrain terrain);
    public IEnumerable<Terrain> GetAll();
    public Terrain GetById(int id);
}
