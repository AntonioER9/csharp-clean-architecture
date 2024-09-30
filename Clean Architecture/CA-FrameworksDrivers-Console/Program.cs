﻿
using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Presenters;
using CA_InterfaceAdapters_Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

IConfiguration configuration = builder.Build();

var container = new ServiceCollection()
    .AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
    .AddScoped<IRepository<Beer>, Repository>()
    .AddScoped<GetBeerUseCase<Beer, BeerViewModel>>()
    .AddScoped<IPresenter<Beer, BeerViewModel>, BeerPresenter>()
    .BuildServiceProvider();

var getBeerUseCase = container.GetService<GetBeerUseCase<Beer, BeerViewModel>>();

var beers = await getBeerUseCase.ExecuteAsync();

foreach (var beer in beers)
{
  Console.WriteLine(beer);
}