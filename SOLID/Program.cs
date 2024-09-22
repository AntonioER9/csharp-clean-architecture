var beerData = new BeerData();
beerData.Add("Heineken");
beerData.Add("Corona");
var reportGeneratorBeer = new ReportGeneratorBeer(beerData);
var report = new Report();
var data = reportGeneratorBeer.Generate();
report.Save(data, "beer.txt");

public class BeerData
{
  private List<string> _beers;
  public BeerData()
  {
    _beers = new List<string>();
  }
  public void Add(string beer)
  {
    _beers.Add(beer);
  }
  public List<string> Get()
  {
    return _beers;
  }
}

public class ReportGeneratorBeer
{
  private BeerData _beerData;
  public ReportGeneratorBeer(BeerData beerData)
  {
    _beerData = beerData;
  }
  public List<string> Generate()
  {
    var data = new List<string>();
    foreach (var beer in _beerData.Get())
    {
      data.Add(beer);
    }
    return data;
  }
}

public class Report
{
  public void Save(List<string> data, string filePath)
  {
    using (var writer = new StreamWriter(filePath))
    {
      foreach (var item in data)
      {
        writer.WriteLine(item);
      }
    }
  }
}