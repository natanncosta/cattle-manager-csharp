using CattleManager.Domain.Interfaces;
using CattleManager.Domain.Models;

namespace CattleManager.Services;

public class TerrainService : ITerrainService
{
    private readonly IRepository<Terrain> _repository;

    public TerrainService(IRepository<Terrain> repository)
        => _repository = repository;

    public ServiceResponse<Terrain> Add(Terrain terrain)
    {
        _repository.Save(terrain);
        return new ServiceResponse<Terrain> { Data = terrain };
    }

    public ServiceResponse<List<Terrain>> GetAll()
    {
        return new ServiceResponse<List<Terrain>>
        {
            Data = _repository.GetAll().ToList()
        };
    }

    public ServiceResponse<Terrain> GetById(int id)
    {
        return new ServiceResponse<Terrain>
        {
            Data = _repository.GetById(id)
        };
    }
}
