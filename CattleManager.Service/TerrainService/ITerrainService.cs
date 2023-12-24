namespace CattleManager.Services.TerrainService;

public interface ITerrainService
{
    ServiceResponse<Terrain> Add(Terrain terrain);
    ServiceResponse<List<Terrain>> GetAll();
    ServiceResponse<Terrain> GetById(int id);
}
