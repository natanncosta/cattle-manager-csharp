namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;
    private readonly IRepository<User> repository;

    public UserController(IUserService service, IRepository<User> repository)
    {
        _service = service;
        this.repository = repository;
    }

    [HttpGet]
    public IActionResult GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public IActionResult GetById(int id) => Ok(_service.GetById(id));
}
