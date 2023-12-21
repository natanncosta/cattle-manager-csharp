namespace CattleManager.Web.Controllers;

[ApiController]
[Route("api/terrain")]
public class TerrainController
{
    private readonly IRepository<Terrain> _repository;
    private readonly ITerrainService _service;

    public TerrainController(IRepository<Terrain> repository, ITerrainService service)
    {
        _repository = repository;
        _service = service;
    }

    [HttpPost]
    public ActionResult<Terrain> Add([FromBody] Terrain terrain)
        => _service.Add(terrain);
}
