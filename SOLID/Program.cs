var beerData = new BeerData();
beerData.Add("Heineken");
beerData.Add("Corona");
var reportGeneratorBeer = new ReportGeneratorBeer(beerData);
var reportGeneratorHTMLBeer = new ReportGeneratorHTMLBeer(beerData);
var report = new Report();
var data = reportGeneratorBeer.Generate();
// report.Save(reportGeneratorBeer, "beer.txt");
report.Save(reportGeneratorHTMLBeer, "beer.html");

public interface IReportGenerator
{
  string Generate();
}

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

public class ReportGeneratorBeer : IReportGenerator
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