using Microsoft.EntityFrameworkCore;
using TechnicalTiagnosis.Core.Entities;

namespace TechnicalTiagnosis.EfCore;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<TechnicalForm> TechnicalForms { get; set; }
    public DbSet<Operator> Operators { get; set; }
    public DbSet<User> Users { get; set; }
}