using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public class ExpiringBeer : Beer
    {
        public DateTime Expiration { get; set; }
        public ExpiringBeer(string name, decimal price, decimal alcohol, DateTime expiration)
            : base(name, price, alcohol)
        {
            Expiration = expiration;
        }

        public override string GetInfo()
        {
            return $"Name: {Name}, Price: {Price}, Expiration: {Expiration}";
        }
    }
}