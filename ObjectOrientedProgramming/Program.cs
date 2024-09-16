using ObjectOrientedProgramming.Business;

Beer budweiser = new Beer("Budweiser", 5.99m, 2, 10);

SendSome(budweiser);

var services = new Service(100, 10);

ISalable[] concepts = [budweiser, services];

void SendSome(ISend some)
{
  some.Send();
}
