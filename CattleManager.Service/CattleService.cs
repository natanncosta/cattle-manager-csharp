using CattleManager.Domain.Interfaces;
using CattleManager.Domain.Models;

namespace CattleManager.Services;

public class CattleService : ICattleService
{
    private readonly IRepository<Cattle> _repository;
    private readonly IUserService _userService;
    private readonly ITerrainService _terrainService;

    public CattleService(IRepository<Cattle> repository, IUserService userService, ITerrainService terrainService)
    {
        _repository = repository;
        _userService = userService;
        _terrainService = terrainService;
    }

    public ServiceResponse<Cattle> Add(Cattle cattle)
    {
        ServiceResponse<Cattle> serviceResponse = new();
        serviceResponse.Data = cattle;
        try
        {
            DoValidations(cattle);
            _repository.Save(cattle);
            return serviceResponse;
        }
        catch (Exception e)
        {
            serviceResponse.Message = e.Message;
            serviceResponse.Success = false;
            return serviceResponse;
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
}
