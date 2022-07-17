using TP_Programación_III.Data.Context;
using TP_Programación_III.Entities;

namespace TP_Programación_III.Repository
{
    public class SaleRepository : ISaleRepository
    {
        private readonly Context _context;

        public SaleRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Sale> GetSales()
        {
            return _context.Sales.ToList();
        }

    }
}
