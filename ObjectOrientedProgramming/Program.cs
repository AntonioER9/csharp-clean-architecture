using ObjectOrientedProgramming.Business;

Beer budweiser = new Beer("Budweiser", 5.99m, -2);
var delirium = new ExpiringBeer("Delirium", 10.99m, 8, new DateTime(2022, 12, 31));

Console.WriteLine($"Name: {budweiser.Name}, Price: {budweiser.Price}");
Console.WriteLine(delirium.GetInfo());

