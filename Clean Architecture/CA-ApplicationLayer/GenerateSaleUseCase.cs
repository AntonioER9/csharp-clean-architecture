using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_ApplicationLayer.Exceptions;
using CA_EnterpriseLayer;

namespace CA_ApplicationLayer
{
    public class GenerateSaleUseCase<TDTO>
    {
        private IRepository<Sale> _repository;
        private readonly IMapper<TDTO, Sale> _mapper;

        public GenerateSaleUseCase(IRepository<Sale> repository, IMapper<TDTO, Sale> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(TDTO dto)
        {
            var sale = _mapper.ToEntity(dto);
            if (sale.Concepts.Count == 0)
            {
                throw new ValidationException("Sale must have at least one concept");
            }
            if (sale.Total <= 0)
            {
                throw new ValidationException("Sale total must be greater than 0");
            }

            await _repository.AddAsync(sale);
        }
    }
}