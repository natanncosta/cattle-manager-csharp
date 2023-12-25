using CattleManager.Infra.Repositories.UserRepository;

namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;
    private readonly IUserRepository repository;

    public UserController(IUserService service, IUserRepository repository)
    {
        _service = service;
        this.repository = repository;
    }

    [HttpGet]
    public ActionResult<ServiceResponse<List<User>>> GetAll()
        => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public ActionResult<ServiceResponse<User>> GetById(int id)
        => Ok(_service.GetById(id));

    [HttpPost]
    public ActionResult<ServiceResponse<User>> Add([FromBody] User newUser)
        => Ok(_service.Add(newUser));
}
