using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_EnterpriseLayer;

namespace CA_ApplicationLayer
{
    public class GetPostUseCase
    {
        private readonly IExternalServiceAdapter<Post> _externalServiceAdapter;
        public GetPostUseCase(IExternalServiceAdapter<Post> externalServiceAdapter)
        {
            _externalServiceAdapter = externalServiceAdapter;
        }
        public async Task<IEnumerable<Post>> ExecuteAsync()
        {
            return await _externalServiceAdapter.GetDataAsync();
        }
    }
}