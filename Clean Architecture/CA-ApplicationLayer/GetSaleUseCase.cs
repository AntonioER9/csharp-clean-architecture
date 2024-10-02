using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_EnterpriseLayer;

namespace CA_ApplicationLayer
{
    public class GetSaleUseCase
    {
        private readonly IRepository<Sale> _saleRepository;
        public GetSaleUseCase(IRepository<Sale> saleRepository)
        {
            _saleRepository = saleRepository;
        }
        public async Task<IEnumerable<Sale>> ExecuteAsync()
        {
            return await _saleRepository.GetAllAsync();
        }
    }
}