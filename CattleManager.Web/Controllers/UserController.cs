using CattleManager.Domain.DTOs.User;

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
    public ActionResult<IEnumerable<GetUserDTO>> GetAll() => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public ActionResult<GetUserDTO> GetById(int id) => Ok(_service.GetById(id));

    [HttpPost]
    public ActionResult<AddUserDTO> Add([FromBody] AddUserDTO newUser) => Ok(_service.Add(newUser));
}
