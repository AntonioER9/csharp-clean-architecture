using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming.Business
{
    public abstract class Drink
    {
        public int Quantity { get; set; }
        public Drink(int quantity)
        {
            Quantity = quantity;
        }
        public string GetQuantity()
        {
            return $"Quantity: {Quantity}";
        }
        public abstract string GetCategory();
    }
}