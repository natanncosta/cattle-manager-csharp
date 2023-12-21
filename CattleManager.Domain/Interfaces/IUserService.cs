using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface IUserService
{
    User Add(User newUser);
    IEnumerable<User> GetAll();
    User GetById(int id);
}
