using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface IUserService
{
    void Add(User user);
    IEnumerable<User> GetAll();
    User GetById(int id);
}
