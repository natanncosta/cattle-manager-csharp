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

    public AddUserDTO Add(AddUserDTO newUser)
    {
        _repository.Save(new User(newUser.Name));
        return newUser;
    }

    public IEnumerable<GetUserDTO> GetAll() => _repository.GetAll().Select(x => _mapper.Map<GetUserDTO>(x));

    public GetUserDTO GetById(int id) => _mapper.Map<GetUserDTO>(_repository.GetById(id));
}
