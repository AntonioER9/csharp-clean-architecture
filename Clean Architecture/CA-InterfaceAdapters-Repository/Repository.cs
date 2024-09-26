using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapters_Data;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapters_Repository;

public class Repository : IRepository
{
  private readonly AppDbContext _dbContext;
  public Repository(AppDbContext dbContext)
  {
    _dbContext = dbContext;
  }
  public async Task AddAsync(Beer beer)
  {
    await _dbContext.Beers.AddAsync(beer); // Add a new beer to the database
    await _dbContext.SaveChangesAsync(); // Save changes to the database
  }
  public async Task<Beer> GetByIdAsync(int id)
  {
    return await _dbContext.Beers.FindAsync(id); // Find a beer by its id
  }
  public async Task<IEnumerable<Beer>> GetAllAsync()
  {
    return await _dbContext.Beers.ToListAsync(); // Get all beers from the database
  }
}
