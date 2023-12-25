using CattleManager.Infra.Context;

namespace CattleManager.Infra.Repositories.UserRepository;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAll()
    {
        var query = _context.Set<User>();
        return query.Any() ? query.ToList() : new List<User>();
    }

    public User GetById(int id)
    {
        var query = _context.Set<User>().Where(x => x.Id == id);
        if (query.Any())
            return query.First();
        return null!;
    }

    public void Save(User user)
    {
        _context.Set<User>().Add(user);
        _context.SaveChangesAsync();
    }
}
