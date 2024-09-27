using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_EnterpriseLayer;

namespace CA_ApplicationLayer
{
    public class AddBeerUseCase<TDTO>
    {
        private readonly IRepository<Beer> _beerRepository;
        private readonly IMapper<TDTO, Beer> _mapper;
        public AddBeerUseCase(IRepository<Beer> beerRepository, IMapper<TDTO, Beer> mapper)
        {
            _beerRepository = beerRepository;
            _mapper = mapper;
        }
        public async Task ExecuteAsync(TDTO dto)
        {
            var beer = _mapper.ToEntity(dto);
            if (string.IsNullOrEmpty(beer.Name))
            {
                throw new ArgumentException("Name is required");
            }
            await _beerRepository.AddAsync(beer);
        }
    }
}