// var beerData = new BeerData();
BeerData beerData = new BeerData();
beerData.Add("Heineken");
beerData.Add("Corona");
beerData.Add("Modelo");
var reportGeneratorBeer = new ReportGeneratorBeer(beerData);
var reportGeneratorHTMLBeer = new ReportGeneratorHTMLBeer(beerData);
var report = new Report();
var data = reportGeneratorBeer.Generate();
// report.Save(reportGeneratorBeer, "beer.txt");
report.Save(reportGeneratorHTMLBeer, "beer.html");

void Show(IReportShow reportGenerator)
{
  reportGenerator.Show();
}

public interface IReportGenerator
{
  string Generate();
}

public interface IReportShow
{
  public void Show();
}

public class BeerData
{
  protected List<string> _beers;
  public BeerData()
  {
    _beers = new List<string>();
  }
  public virtual void Add(string beer)
  {
    _beers.Add(beer);
  }
  public List<string> Get()
  {
    return _beers;
  }
}

// public class LimitedBeerData : BeerData // Violación de Liskov
// {
//   private int _limit;
//   public LimitedBeerData(int limit)
//   {
//     _limit = limit;
//   }
//   public override void Add(string beer)
//   {
//     if (_beers.Count >= _limit)
//     {
//       throw new Exception("No se pueden agregar más cervezas");
//     }
//     base.Add(beer);
//   }
// }

public class LimitedBeerData
{
  private BeerData _beerData = new BeerData();
  private int _limit;
  private int _count = 0;
  public LimitedBeerData(int limit)
  {
    _limit = limit;
  }
  public void Add(string beer)
  {
    if (_count >= _limit)
    {
      throw new Exception("No se pueden agregar más cervezas");
    }
    _beerData.Add(beer);
    _count++;
  }

  public List<string> Get()
  {
    return _beerData.Get();
  }
}

public class ReportGeneratorBeer : IReportGenerator, IReportShow
{
  private BeerData _beerData;
  public ReportGeneratorBeer(BeerData beerData)
  {
    _beerData = beerData;
  }
  public string Generate()
  {
    string data = "";
    foreach (var beer in _beerData.Get())
    {
      data += "Cerveza: " + beer + Environment.NewLine;
    }
    return data;
  }
  public void Show()
  {
    foreach (var beer in _beerData.Get())
    {
      Console.WriteLine("Cerveza: " + beer);
    }
  }
}

public class ReportGeneratorHTMLBeer : IReportGenerator
{
  private BeerData _beerData;
  public ReportGeneratorHTMLBeer(BeerData beerData)
  {
    _beerData = beerData;
  }
  public string Generate()
  {
    string data = "<html><body>";
    foreach (var beer in _beerData.Get())
    {
      data += "<p>Cerveza: " + beer + "</p>";
    }
    data += "</body></html>";
    return data;
  }
}

public class Report
{
  public void Save(IReportGenerator reportGenerator, string filePath)
  {
    using (var writer = new StreamWriter(filePath))
    {
      string data = reportGenerator.Generate();
      writer.WriteLine(data);
    }
  }
}