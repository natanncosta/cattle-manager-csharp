namespace CattleManager.Infra.Repositories.UserRepository;

public interface IUserRepository
{
    public User GetById(int id);
    public IEnumerable<User> GetAll();
    public void Save(User entity);
}
