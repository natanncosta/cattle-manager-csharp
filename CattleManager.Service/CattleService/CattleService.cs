using CattleManager.Services.TerrainService;
using CattleManager.Services.UserService;

namespace CattleManager.Services.CattleService;

public class CattleService : ICattleService
{
    private readonly ICattleRepository _repository;
    private readonly IUserService _userService;
    private readonly ITerrainService _terrainService;

    public CattleService(ICattleRepository repository, IUserService userService, ITerrainService terrainService)
    {
        _repository = repository;
        _userService = userService;
        _terrainService = terrainService;
    }

    public ServiceResponse<Cattle> Add(Cattle cattle)
    {
        try
        {
            DoValidations(cattle);
            _repository.Save(cattle);
            return new ServiceResponse<Cattle>(cattle);
        }
        catch (Exception e)
        {
            return new ServiceResponse<Cattle>(false, e.Message);
        }
    }

    private void DoValidations(Cattle cattle)
    {
        UserExists(cattle.UserId);
        TerrainExists(cattle.TerrainId);
        ValidateEarringLength(cattle.Earring);
    }

    private void ValidateEarringLength(string earring)
    {
        if (earring.Length < 10)
            throw new Exception("Earring invalid");
    }

    private void TerrainExists(int id)
    {
        if (_terrainService.GetById(id) == null)
            throw new Exception("Terrain not found");
    }

    private void UserExists(int id)
    {
        if (_userService.GetById(id) == null)
            throw new Exception("User not found");
    }

    public ServiceResponse<IEnumerable<Cattle>> GetAll()
        => new ServiceResponse<IEnumerable<Cattle>>(_repository.GetAll());

    public ServiceResponse<Cattle> GetById(int id)
    {
        Cattle cattle = _repository.GetById(id);
        if (cattle is null)
            return new ServiceResponse<Cattle>(false, "Cattle not found");
        return new ServiceResponse<Cattle>(cattle);
    }
}
