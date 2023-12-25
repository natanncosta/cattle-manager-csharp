using CattleManager.Infra.Repositories.CattleRepository;

namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/cattle")]
public class CattleController : ControllerBase
{
    private readonly ICattleRepository _repository;
    private readonly ICattleService _service;

    public CattleController(ICattleRepository repository, ICattleService service)
    {
        _repository = repository;
        _service = service;
    }

    [HttpPost]
    public ActionResult<ServiceResponse<Cattle>> Add([FromBody] Cattle cattle)
        => Ok(_service.Add(cattle));
}
