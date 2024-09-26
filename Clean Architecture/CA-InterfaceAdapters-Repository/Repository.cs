using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Models;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapters_Repository;

public class Repository : IRepository<BeerModel>
{
  private readonly AppDbContext _dbContext;
  public Repository(AppDbContext dbContext)
  {
    _dbContext = dbContext;
  }
  public async Task AddAsync(Beer beer)
  {
    var beerModel = new BeerModel()
    {
      Name = beer.Name,
      Style = beer.Style,
      Alcohol = beer.Alcohol
    };
    await _dbContext.Beers.AddAsync(beerModel); // Add a new beer to the database
    await _dbContext.SaveChangesAsync(); // Save changes to the database
  }
  public async Task<BeerModel> GetByIdAsync(int id)
  {
    return await _dbContext.Beers.FindAsync(id); // Find a beer by its id
  }
  public async Task<IEnumerable<BeerModel>> GetAllAsync()
  {
    return await _dbContext.Beers.ToListAsync(); // Get all beers from the database
  }
}
