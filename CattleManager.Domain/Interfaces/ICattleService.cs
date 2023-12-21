using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface ICattleService
{
    public Cattle Add(Cattle cattle);
}
