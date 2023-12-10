using CattleManager.Domain.Models;
using CattleManager.Infra.Context;

namespace CattleManager.Infra.Repositories;

public class UserRepository : Repository<User>
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }

    public override IEnumerable<User> GetAll()
    {
        var query = _context.Set<User>();
        return query.Any() ? query.ToList() : new List<User>();
    }

    public override User GetById(int id)
    {
        var query = _context.Set<User>().Where(x => x.Id == id);
        if (query.Any())
            return query.First();
        return null!;
    }
}
