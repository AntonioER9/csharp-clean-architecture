using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public class Service : ISalable
    {
        private decimal _amount;
        private decimal _tax;

        public Service(decimal amount, decimal tax)
        {
            _amount = amount;
            _tax = tax;
        }

        public decimal GetPrice()
        {
            return _amount + _tax;
        }

    }
}