using BusinessComponent;
using RepositoryComponent;

var beerManager = new BeerManager(new BeerRepository());
beerManager.AddBeer("Heineken");
beerManager.AddBeer("Budweiser");
Console.WriteLine(beerManager.GetBeer());