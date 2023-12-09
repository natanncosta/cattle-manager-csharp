using CattleManager.Domain.Interfaces;
using CattleManager.Infra.Context;

namespace CattleManager.Infra.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task commit()
    {
        await _context.SaveChangesAsync();
    }
}
