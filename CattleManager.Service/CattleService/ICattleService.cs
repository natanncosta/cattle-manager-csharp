namespace CattleManager.Services.CattleService;

public interface ICattleService
{
    public ServiceResponse<Cattle> Add(Cattle cattle);
}
