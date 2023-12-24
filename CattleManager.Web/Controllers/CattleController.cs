namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/cattle")]
public class CattleController : ControllerBase
{
    private readonly IRepository<Cattle> _repository;
    private readonly ICattleService _service;

    public CattleController(IRepository<Cattle> repository, ICattleService service)
    {
        _repository = repository;
        _service = service;
    }

    [HttpPost]
    public ActionResult<ServiceResponse<Cattle>> Add([FromBody] Cattle cattle)
        => Ok(_service.Add(cattle));
}
