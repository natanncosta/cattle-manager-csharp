namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/terrain")]
public class TerrainController : ControllerBase
{
    private readonly IRepository<Terrain> _repository;
    private readonly ITerrainService _service;

    public TerrainController(IRepository<Terrain> repository, ITerrainService service)
    {
        _repository = repository;
        _service = service;
    }

    [HttpPost]
    public ActionResult<ServiceResponse<Terrain>> Add([FromBody] Terrain terrain)
        => Ok(_service.Add(terrain));

    [HttpGet]
    public ActionResult<ServiceResponse<List<Terrain>>> GetAll()
        => Ok(_service.GetAll());

    [HttpGet("{id}")]
    public ActionResult<ServiceResponse<Terrain>> GetById(int id)
        => Ok(_service.GetById(id));
}

