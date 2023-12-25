namespace CattleManager.Infra.Repositories.TerrainRepository;

public interface ITerrainRepository
{
    public Terrain GetByName(string description);
    Terrain GetById(int id);
    IEnumerable<Terrain> GetAll();
    void Save(Terrain entity);
}
