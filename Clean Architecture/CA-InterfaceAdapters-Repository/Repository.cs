using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Models;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapters_Repository;

public class Repository : IRepository<Beer>
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
  public async Task<Beer> GetByIdAsync(int id)
  {
    var beerModel = await _dbContext.Beers.FindAsync(id); // Find a beer by its id
    return new Beer
    {
      Id = beerModel.Id,
      Name = beerModel.Name,
      Style = beerModel.Style,
      Alcohol = beerModel.Alcohol
    };
  }
  public async Task<IEnumerable<Beer>> GetAllAsync()
  {
    return await _dbContext.Beers
    .Select(beer => new Beer
    {
      Id = beer.Id,
      Name = beer.Name,
      Style = beer.Style,
      Alcohol = beer.Alcohol
    })
    .ToListAsync(); // Get all beers from the database
  }
}
