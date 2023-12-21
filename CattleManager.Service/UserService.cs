global using AutoMapper;

using CattleManager.Domain.Models;
using CattleManager.Domain.Interfaces;

namespace CattleManager.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _repository;
    private readonly IMapper _mapper;

    public UserService(
            IRepository<User> repository,
            IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public User Add(User newUser)
    {
        _repository.Save(newUser);
        return newUser;
    }

    public IEnumerable<User> GetAll()
        => _repository.GetAll();

    public User GetById(int id)
        => _repository.GetById(id);
}
