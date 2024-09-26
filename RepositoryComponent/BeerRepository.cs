using BusinessComponent;

namespace RepositoryComponent;

public class BeerRepository : IRepository
{
  private List<string> _beers;
  public BeerRepository()
  {
    _beers = new List<string>();
  }
  public void Add(string beerName)
  {
    _beers.Add(beerName);
  }
  public string Get()
  => _beers.Aggregate("", (current, beer) => current + beer + ", ");
}
