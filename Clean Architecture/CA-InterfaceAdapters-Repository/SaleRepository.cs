using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapters_Data;
using CA_InterfaceAdapters_Models;

namespace CA_InterfaceAdapters_Repository
{
    public class SaleRepository : IRepository<Sale>
    {
        private readonly AppDbContext _context;
        public async Task AddAsync(Sale sale)
        {
            var saleModel = new SaleModel();
            saleModel.Total = sale.Total;
            saleModel.Date = sale.Date;
            saleModel.Concepts = sale.Concepts.Select(c => new ConceptModel
            {
                IdBeer = c.IdBeer,
                Quantity = c.Quantity,
                UnitPrice = c.UnitPrice
            }).ToList();
            await _context.Sales.AddAsync(saleModel);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Sale>> GetAllAsync()
         => await _context.Sales
            .Select(s => new Sale(s.Id, s.Date,
            _context.Concepts.Where(c => c.IdSale == s.Id)
            .Select(c => new Concept(c.Quantity, c.IdBeer, c.UnitPrice)).ToList()
            )).ToListAsync();

        public async Task<Sale> GetByIdAsync(int id)
        {
            var saleModel = await _context.Sales.FindAsync(id);
            return new Sale(saleModel.Id, saleModel.Date,
                _context.Concepts.Where(c => c.IdSale == saleModel.Id)
                .Select(c => new Concept(c.Quantity, c.IdBeer, c.UnitPrice)).ToList());
        }
    }
}