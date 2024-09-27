using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_ApplicationLayer;
using CA_EnterpriseLayer;

namespace CA_InterfaceAdapters_Presenters
{
    public class BeerPresenter : IPresenter<Beer, BeerViewModel>
    {
        public IEnumerable<BeerViewModel> Present(IEnumerable<Beer> beers)
        {
            return beers.Select(beer => new BeerViewModel
            {
                Id = beer.Id,
                Name = beer.Name,
                Alcohol = beer.Alcohol + "%"
            });
        }
    }
}