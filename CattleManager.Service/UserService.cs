using CattleManager.Domain.Models;
using CattleManager.Domain.Interfaces;
using CattleManager.Infra.Repositories;
using CattleManager.Infra.Context;
using CattleManager.Domain.DTOs;

namespace CattleManager.Services;

public class UserService : IUserService
{
    private readonly AppDbContext _repository;

    public UserService(AppDbContext repository)
        => _repository = repository;

    public void Add(User user)
    {
        UserExists(user.Id);
        // _repository.Save(user);
        // _repository.Users.;
    }

    public IEnumerable<GetUserDTO> GetAll()
    {
        throw new NotImplementedException();
    }

    public User GetById(int id)
    {
        throw new NotImplementedException();
    }

    private void UserExists(int id)
    {
        // if (_repository.GetById(id) != null)
        throw new Exception("User already exists");
    }
}
