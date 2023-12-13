using CattleManager.Domain.DTOs.User;
using CattleManager.Domain.Models;

namespace CattleManager.Domain.Interfaces;

public interface IUserService
{
    void Add(User user);
    IEnumerable<GetUserDTO> GetAll();
    GetUserDTO GetById(int id);
}
