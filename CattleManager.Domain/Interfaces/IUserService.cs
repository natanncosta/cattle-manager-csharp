using CattleManager.Domain.DTOs.User;

namespace CattleManager.Domain.Interfaces;

public interface IUserService
{
    AddUserDTO Add(AddUserDTO newUser);
    IEnumerable<GetUserDTO> GetAll();
    GetUserDTO GetById(int id);
}
