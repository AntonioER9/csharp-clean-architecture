using CA_EnterpriseLayer;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapters_Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  public DbSet<Beer> Beers { get; set; } // DbSet is a collection of entities that can be queried
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Beer>().ToTable("Beers");
  }
}
