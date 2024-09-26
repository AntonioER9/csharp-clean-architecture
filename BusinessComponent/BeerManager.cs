namespace BusinessComponent;

public class BeerManager
{
  private IRepository _repository;

  public BeerManager(IRepository repository)
  {
    _repository = repository;
  }

  public void AddBeer(string beerName)
  {
    if (string.IsNullOrEmpty(beerName))
    {
      throw new ArgumentNullException(nameof(beerName));
    }
    _repository.Add(beerName);
  }

  public string GetBeer()
  {
    return _repository.Get();
  }
}
