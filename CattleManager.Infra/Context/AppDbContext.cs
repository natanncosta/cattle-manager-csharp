using CattleManager.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CattleManager.Infra.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Cattle> Cattles { get; set; }
    public DbSet<Terrain> Terrains { get; set; }
}
