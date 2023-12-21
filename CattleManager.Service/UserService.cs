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

    public ServiceResponse<User> Add(User newUser)
    {
        _repository.Save(newUser);
        return new ServiceResponse<User>
        {
            Data = newUser,
            Message = "Created with success"
        };
    }

    public ServiceResponse<List<User>> GetAll()
    {
        return new ServiceResponse<List<User>>
        {
            Data = _repository.GetAll().ToList()
        };
    }

    public ServiceResponse<User> GetById(int id)
    {
        return new ServiceResponse<User>
        {
            Data = _repository.GetById(id)
        };
    }
}
