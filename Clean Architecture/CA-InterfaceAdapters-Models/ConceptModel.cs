using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_InterfaceAdapters_Models
{
    public class ConceptModel
    {
        public int Id { get; set; }
        public int IdBeer { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int IdSale { get; set; }
    }
}