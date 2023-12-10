namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;
    private readonly IRepository<User> _repository;

    public UserController(IUserService service, IRepository<User> repository)
    {
        _service = service;
        _repository = repository;
    }


    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAll()
    {
        return new List<User>();
    }
}
