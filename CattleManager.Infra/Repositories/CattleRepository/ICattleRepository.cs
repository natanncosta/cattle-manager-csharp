namespace CattleManager.Infra.Repositories.CattleRepository;

public interface ICattleRepository
{
    Cattle GetById(int id);
    IEnumerable<Cattle> GetAll();
    void Save(Cattle cattle);
}
