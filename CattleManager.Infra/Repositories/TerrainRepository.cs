using CattleManager.Domain.Models;
using CattleManager.Infra.Context;

namespace CattleManager.Infra.Repositories;

public class TerrainRepository : Repository<Terrain>
{
    public TerrainRepository(AppDbContext context) : base(context)
    {
    }
}
