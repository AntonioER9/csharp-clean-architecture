using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_InterfaceAdapter_Adapters
{
    public interface IExternalService<T>
    {
        public Task<IEnumerable<T>> GetContentAsync();
    }
}