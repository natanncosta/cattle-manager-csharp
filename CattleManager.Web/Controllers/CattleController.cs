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
    public ActionResult<Cattle> Add([FromBody] Cattle cattle)
    {
        try
        {
            return Ok(_service.Add(cattle));
        }
        catch (System.Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
