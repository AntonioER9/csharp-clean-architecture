using ObjectOrientedProgramming.Business;

Beer budweiser = new Beer("Budweiser", 5.99m, 2, 10);

SendSome(budweiser);

var services = new Service(100, 10);

ISalable[] concepts = [budweiser, services];

void SendSome(ISend some)
{
  some.Send();
}

var elements = new Collection<int>(5);
elements.Add(1);
elements.Add(2);
elements.Add(3);
elements.Add(4);

foreach (var element in elements.Get())
{
  Console.WriteLine(element);
}

var names = new Collection<string>(5);
names.Add("John");
names.Add("Jane");
names.Add("Jack");
foreach (var name in names.Get())
{
  Console.WriteLine(name);
}

Console.WriteLine($"Objetos creados: {Beer.QuantityObjects}");
Console.WriteLine(Operations.Add(1, 2));