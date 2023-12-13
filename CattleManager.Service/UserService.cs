global using AutoMapper;

using CattleManager.Domain.Models;
using CattleManager.Domain.Interfaces;
using CattleManager.Domain.DTOs.User;

namespace CattleManager.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _repository;
    private readonly IMapper _mapper;

    public UserService(IRepository<User> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public void Add(User user)
    {
        UserExists(user.Id);
        // _repository.Save(user);
        // _repository.Users.;
    }

    public IEnumerable<GetUserDTO> GetAll()
    {
        return _repository.GetAll().Select(x => _mapper.Map<GetUserDTO>(x));
    }

    public GetUserDTO GetById(int id)
    {
        return _mapper.Map<GetUserDTO>(_repository.GetById(id));
    }

    private void UserExists(int id)
    {
        // if (_repository.GetById(id) != null)
        throw new Exception("User already exists");
    }
}
