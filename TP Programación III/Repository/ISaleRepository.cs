using TP_Programación_III.Entities;

namespace TP_Programación_III.Repository
{
    public interface ISaleRepository
    {
        public IEnumerable<Sale> GetSales();
    }
}
