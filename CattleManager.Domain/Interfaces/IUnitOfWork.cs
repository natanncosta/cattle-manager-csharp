namespace CattleManager.Domain.Interfaces;

public interface IUnitOfWork
{
    Task commit();
}
