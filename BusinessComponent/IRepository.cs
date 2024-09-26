using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessComponent
{
    public interface IRepository
    {
        void Add(string beerName);
        string Get();
    }
}