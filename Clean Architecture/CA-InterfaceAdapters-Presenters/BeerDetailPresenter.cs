using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_ApplicationLayer;
using CA_EnterpriseLayer;

namespace CA_InterfaceAdapters_Presenters
{
    public class BeerDetailPresenter : IPresenter<Beer, BeerDetailViewModel>
    {
        public IEnumerable<BeerDetailViewModel> Present(IEnumerable<Beer> beers)
        {
            return beers.Select(beer => new BeerDetailViewModel
            {
                Id = beer.Id,
                Name = beer.Name,
                Alcohol = beer.Alcohol + "%",
                Color = beer.IsStrongBeer() ? "Dark" : "Light",
                Style = beer.Style,
                Message = beer.IsStrongBeer() ? "Be careful, it's a strong beer!" : "Enjoy it!"
            });
        }
    }
}