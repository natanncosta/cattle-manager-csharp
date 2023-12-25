
namespace CattleManager.Infra.Repositories.CattleRepository;

public class CattleRepository : ICattleRepository
{
    private readonly AppDbContext _context;

    public CattleRepository(AppDbContext context)
    { _context = context; }

    public IEnumerable<Cattle> GetAll()
    {
        var query = _context.Set<Cattle>();
        if (query.Any())
            return query.ToList();
        return new List<Cattle>();
    }

    public Cattle GetById(int id)
    {
        var query = _context.Set<Cattle>().Where(x => x.Id == id);
        if (query.Any())
            return query.FirstOrDefault()!;
        return null!;
    }

    public void Save(Cattle cattle)
    {
        _context.Set<Cattle>().Add(cattle);
        _context.SaveChangesAsync();

    }
}
