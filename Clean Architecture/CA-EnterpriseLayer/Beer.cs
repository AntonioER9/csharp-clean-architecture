namespace CA_EnterpriseLayer;

public class Beer
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Style { get; set; }
  public decimal Alcohol { get; set; }
  public bool IsStrongBeer() => Alcohol > 6.0m;
}
