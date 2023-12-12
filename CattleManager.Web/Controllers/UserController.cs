using CattleManager.Domain.DTOs;

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
    public ActionResult<IEnumerable<GetUserDTO>> GetAll()
    {
        return Ok(_service.GetAll());
    }
}
