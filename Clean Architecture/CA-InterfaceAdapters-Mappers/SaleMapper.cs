using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_ApplicationLayer;
using CA_EnterpriseLayer;

namespace CA_InterfaceAdapters_Mappers
{
    public class SaleMapper : IMapper<SaleRequestDTO, Sale>
    {
        public Sale ToEntity(SaleRequestDTO dto)
        {
            var concepts = new List<Concept>();

            foreach (var concept in dto.Concepts)
            {
                concepts.Add(new Concept(concept.Quantity, concept.IdBeer, concept.UnitPrice));
            }
            return new Sale(DateTime.Now, concepts);
        }
    }
}