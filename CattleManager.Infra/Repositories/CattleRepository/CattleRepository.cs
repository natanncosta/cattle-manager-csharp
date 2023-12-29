
namespace CattleManager.Infra.Repositories.CattleRepository;

public class CattleRepository : ICattleRepository
{
    private readonly AppDbContext _context;

    public CattleRepository(AppDbContext context)
    { _context = context; }

    public void Delete(int id)
    {
        _context.Set<Cattle>().Remove(GetById(id));
        _context.SaveChangesAsync();
    }

    public IEnumerable<Cattle> GetAll()
    {
        var query = _context.Set<Cattle>();
        if (query.Any())
            return query.ToList();
        return new List<Cattle>();
    }

    public Cattle GetByEarring(string earring)
    {
        var query = _context.Set<Cattle>().Where(x => x.Earring == earring);
        if (query.Any())
            return query.FirstOrDefault()!;
        return null!;
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

    public void Update(Cattle updatedCattle)
    {
        var cattle = _context.Set<Cattle>().FirstOrDefault(c => c.Earring == updatedCattle.Earring)!;
        cattle.Name = updatedCattle.Name;
        cattle.UserId = updatedCattle.UserId;
        cattle.TerrainId = updatedCattle.TerrainId;
        cattle.Earring = updatedCattle.Earring;
        _context.SaveChangesAsync();
    }
}
