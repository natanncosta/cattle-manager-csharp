using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface ITerrainService
{
    ServiceResponse<Terrain> Add(Terrain terrain);
    ServiceResponse<List<Terrain>> GetAll();
    ServiceResponse<Terrain> GetById(int id);
}
