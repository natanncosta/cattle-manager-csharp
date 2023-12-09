using CattleManager.Domain.Interfaces;

namespace CattleManager.Domain.Models;

public class UserService
{
    private readonly IRepository<User> _repository;

    public UserService(IRepository<User> repository)
    {
        _repository = repository;
    }

    public void Save(User user)
    {
        UserExists(user.Id);
        _repository.Save(user);
    }

    private void UserExists(int id)
    {
        if (_repository.GetById(id) != null)
            throw new Exception("User already exists");
    }
}
