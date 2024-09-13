int limit = 10;
var beers = new string[limit];
int iBeers = 0;
int op = 0;

do
{
    ShowMenu();
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            if (iBeers < limit)
            {
                Console.Clear();
                Console.WriteLine("Enter the beer name:");
                var beer = Console.ReadLine();
                beers[iBeers] = beer;
                iBeers++;
            }
            else
            {
                Console.WriteLine("No more space for beers");
            }
            break;
        case 2:
            ShowBeers(beers, iBeers);
            break;
        case 3:
            Console.WriteLine("Bye!");
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }

} while (op != 3);

void ShowMenu()
{
    Console.WriteLine("1 - Add beer");
    Console.WriteLine("2 - List beers");
    Console.WriteLine("3 - Exit");
}

void ShowBeers(string[] beers, int iBeers)
{
    Console.Clear();
    Console.WriteLine("Beers:");
    for (int i = 0; i < iBeers; i++)
    {
        Console.WriteLine(beers[i]);
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadLine();
}