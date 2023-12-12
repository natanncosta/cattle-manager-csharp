using CattleManager.Domain.DTOs;
using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface IUserService
{
    void Add(User user);
    IEnumerable<GetUserDTO> GetAll();
    User GetById(int id);
}
