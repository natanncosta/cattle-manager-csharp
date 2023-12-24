using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface ITerrainRepository
{
    public Terrain GetByName(string description);
    Terrain GetById(int id);
    IEnumerable<Terrain> GetAll();
    void Save(Terrain entity);
}
