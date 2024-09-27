using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapters_Mappers.Dtos.Requests;

namespace CA_InterfaceAdapters_Mappers;

public class BeerMapper : IMapper<BeerRequestDTO, Beer>
{
  public Beer ToEntity(BeerRequestDTO dto)
  {
    return new Beer
    {
      Id = dto.Id,
      Name = dto.Name,
      Alcohol = dto.Alcohol,
      Style = dto.Style
    };
  }
}
