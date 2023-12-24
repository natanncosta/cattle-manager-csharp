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
        return new ServiceResponse<Terrain>(terrain);
    }

    public ServiceResponse<List<Terrain>> GetAll()
        => new ServiceResponse<List<Terrain>>(_repository.GetAll().ToList());

    public ServiceResponse<Terrain> GetById(int id)
    {
        var terrain = _repository.GetById(id);
        if (terrain is null)
            return new ServiceResponse<Terrain>(success: false, message: "Terrain not found");
        return new ServiceResponse<Terrain>(terrain);
    }
}
