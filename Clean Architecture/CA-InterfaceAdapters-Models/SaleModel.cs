using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_InterfaceAdapters_Models
{
    public class SaleModel
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public List<ConceptModel> Concepts { get; set; }
        public DateTime Date { get; set; }
    }
}