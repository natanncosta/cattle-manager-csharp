using CattleManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CattleManager.Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users => Set<User>();
    public DbSet<Cattle> Cattles => Set<Cattle>();
    public DbSet<Terrain> Terrains => Set<Terrain>();
}
