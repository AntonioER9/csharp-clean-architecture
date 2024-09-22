public class Beer
{
  private List<string> _beers;
  public Beer()
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
  public List<string> GetReport()
  {
    var data = new List<string>();
    foreach (var beer in _beers)
    {
      data.Add("Cerveza: " + beer);
    }
    return data;
  }
  public void SaveReport(string filePath)
  {
    using (var writer = new StreamWriter(filePath))
    {
      foreach (var beer in GetReport())
      {
        writer.WriteLine(beer);
      }
    }
  }
}