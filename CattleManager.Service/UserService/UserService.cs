namespace CattleManager.Services.UserService;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserService(
            IUserRepository repository,
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
        => new ServiceResponse<List<User>>(_repository.GetAll().ToList());

    public ServiceResponse<User> GetById(int id)
    {
        return new ServiceResponse<User>(_repository.GetById(id));
    }
}
