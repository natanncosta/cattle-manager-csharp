namespace CattleManager.Services.CattleService;

public interface ICattleService
{
    ServiceResponse<Cattle> Add(Cattle cattle);
    ServiceResponse<Cattle> Delete(int id);
    ServiceResponse<IEnumerable<Cattle>> GetAll();
    ServiceResponse<Cattle> GetById(int id);
    ServiceResponse<Cattle> Update(Cattle updatedCattle);
}
