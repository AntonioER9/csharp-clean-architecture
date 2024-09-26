using BusinessComponent;
using Microsoft.Extensions.DependencyInjection;
using RepositoryComponent;

var container = new ServiceCollection()
  .AddSingleton<IRepository, BeerRepository>()
  .AddTransient<BeerManager>()
  .BuildServiceProvider();

var beerManager = container.GetService<BeerManager>();
beerManager.AddBeer("Heineken");
beerManager.AddBeer("Budweiser");
Console.WriteLine(beerManager.GetBeer());