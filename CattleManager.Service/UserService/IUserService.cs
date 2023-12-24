namespace CattleManager.Services.UserService;

public interface IUserService
{
    ServiceResponse<User> Add(User newUser);
    ServiceResponse<List<User>> GetAll();
    ServiceResponse<User> GetById(int id);
}
