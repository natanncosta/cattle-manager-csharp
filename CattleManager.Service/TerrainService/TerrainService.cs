namespace CattleManager.Services.TerrainService;

public class TerrainService : ITerrainService
{
    private readonly ITerrainRepository _repository;

    public TerrainService(ITerrainRepository repository)
        => _repository = repository;

    public ServiceResponse<Terrain> Add(Terrain terrain)
    {
        bool terrainExists = _repository.GetByName(terrain.Description) is not null;
        if (terrainExists)
            return new ServiceResponse<Terrain>(success: false, message: "Terrain already exists");
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
