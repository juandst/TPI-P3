using TP_Programación_III.Data.Context;
using TP_Programación_III.Entities;

namespace TP_Programación_III.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public Product GetProductById(int id)
        {
            return _context.Products.Where(p => p.ID == id).FirstOrDefault();
        }

        public Product GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.OrderBy(p => p.Name).ToList(); 
        }
    }
}
