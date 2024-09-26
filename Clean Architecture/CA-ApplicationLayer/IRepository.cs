using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_EnterpriseLayer;

namespace CA_ApplicationLayer
{
    public interface IRepository
    {
        Task<Beer> GetByIdAsync(int id);
        Task<IEnumerable<Beer>> GetAllAsync();
        Task AddAsync(Beer beer);
    }
}