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

    [HttpGet]
    public ActionResult<ServiceResponse<IEnumerable<Cattle>>> GetAll()
        => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public ActionResult<ServiceResponse<Cattle>> GetById(int id)
        => Ok(_service.GetById(id));

    [HttpPut]
    public ActionResult<ServiceResponse<Cattle>> Update([FromBody] Cattle updatedCattle)
        => Ok(_service.Update(updatedCattle));

    [HttpDelete("{id}")]
    public ActionResult<ServiceResponse<Cattle>> Delete(int id)
        => Ok(_service.Delete(id));
}
