using ObjectOrientedProgramming.Business;

Beer budweiser = new Beer("Budweiser", 5.99m, -2, 10);
var delirium = new ExpiringBeer("Delirium", 10.99m, 8, new DateTime(2022, 12, 31), 5);
Drink drink = new Beer("Corona", 4.99m, 5, 10);


Console.WriteLine($"Name: {budweiser.Name}, Price: {budweiser.Price}");
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(drink.GetCategory());
