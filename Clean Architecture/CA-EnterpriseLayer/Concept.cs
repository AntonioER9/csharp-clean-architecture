using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_EnterpriseLayer
{
    public class Concept
    {
        public int IdBeer { get; }
        public int Quantity { get; }
        public decimal UnitPrice { get; }
        public decimal Price { get; }

        public Concept(int quantity, int idBeer, decimal unitPrice)
        {
            Quantity = quantity;
            IdBeer = idBeer;
            UnitPrice = unitPrice;
            Price = GetTotalPrice();
        }
        private decimal GetTotalPrice()
        {
            return Quantity * UnitPrice;
        }
    }
}