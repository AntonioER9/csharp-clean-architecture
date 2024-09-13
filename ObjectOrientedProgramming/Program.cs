Beer budweiser = new Beer { Name = "Budweiser", Price = 5.99m };

var coronaBeer = new Beer { Name = "Corona", Price = 6.99m };

Console.WriteLine($"Name: {budweiser.Name}, Price: {budweiser.Price}");

public class Beer
{
  public string Name { get; set; }
  public decimal Price { get; set; }
  public string GetInfo()
  {
    return $"Name: {Name}, Price: {Price}";
  }
}

