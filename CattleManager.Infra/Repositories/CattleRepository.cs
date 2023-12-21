using CattleManager.Domain.Models;
using CattleManager.Infra.Context;

namespace CattleManager.Infra.Repositories;

public class CattleRepository : Repository<Cattle>
{
    public CattleRepository(AppDbContext context) : base(context)
    {
    }
}
