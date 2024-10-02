using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CA_EnterpriseLayer;

namespace CA_ApplicationLayer
{
    public class GetSaleSearchUseCase
    {
        private readonly IRepositorySearch<TModel, Sale> _repositorySearch;
        public GetSaleSearchUseCase(IRepositorySearch<TModel, Sale> repositorySearch)
        {
            _repositorySearch = repositorySearch;
        }
        public async Task<IEnumerable<Sale>> ExecuteAsync(Expression<Func<TModel, bool>> predicate)
        {
            return await _repositorySearch.GetAsync(predicate);
        }
    }
}