var t = TomorrowPure;
Console.WriteLine(t(new DateTime(2021, 1, 1)));

Action<string> show = Console.WriteLine;
show("Hello, World!"); // Hello, World!

Action<string> hi = name => Console.WriteLine($"Hi, {name}!");
hi("John"); // Hi, John!
Action<int, int> add = (a, b) => Console.WriteLine(a + b);
add(1, 2); // 3

Func<int, int, int> sum = (a, b) => a + b;
show(sum(1, 2).ToString()); // 3

Func<int, int, string> mulString = (a, b) =>
{
  var result = a * b;
  return result.ToString();
};
show(mulString(2, 3)); // 6

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Predicate<int> isEven = n => n % 2 == 0;

var numbersFiltered = Filter(numbers, n => n % 2 == 0);

foreach (var number in numbersFiltered)
{
  Console.WriteLine(number);
}

List<int> Filter(List<int> list, Func<int, bool> condition)
{
  var result = new List<int>();
  foreach (var item in list)
  {
    if (condition(item))
    {
      result.Add(item);
    }
  }
  return result;
}
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
