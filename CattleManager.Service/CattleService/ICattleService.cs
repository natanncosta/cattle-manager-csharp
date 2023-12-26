namespace CattleManager.Services.CattleService;

public interface ICattleService
{
    ServiceResponse<Cattle> Add(Cattle cattle);
    ServiceResponse<IEnumerable<Cattle>> GetAll();
}
