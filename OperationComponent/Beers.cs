using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperationComponent
{
    public class Beers
    {
        private List<string> _beers;
        public Beers() => _beers = new List<string>();

        public void Add(string beer) => _beers.Add(beer);
        public List<string> Get() => _beers;
    }
}