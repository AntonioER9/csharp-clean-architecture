// Función no pura
DateTime Tomorrow()
{
  return DateTime.Now.AddDays(1);
}

Beer ToUpper(Beer beer)
{
  beer.Name = beer.Name.ToUpper();
  return beer;
}
// Función pura
DateTime TomorrowPure(DateTime date)
{
  return date.AddDays(1);
}

Beer ToUpperPure(Beer beer)
{
  var newBeer = new Beer() { Name = beer.Name.ToUpper() };
  return newBeer;
}

var beer = new Beer() { Name = "Corona" };

Console.WriteLine(ToUpperPure(beer).Name);
Console.WriteLine(beer.Name);

Console.WriteLine(Tomorrow());
Console.WriteLine(TomorrowPure(DateTime.Now));



public class Beer
{
  public string Name { get; set; }
}
