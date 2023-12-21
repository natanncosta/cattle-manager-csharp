using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface ICattleService
{
    public ServiceResponse<Cattle> Add(Cattle cattle);
}
