namespace CattleManager.Infra.Repositories.CattleRepository;

public interface ICattleRepository
{
    Cattle GetById(int id);
    IEnumerable<Cattle> GetAll();
    void Save(Cattle cattle);
    void Update(Cattle updatedCattle);
    Cattle GetByEarring(string earring);
    void Delete(int id);
}
