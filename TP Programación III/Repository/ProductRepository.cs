using TP_Programación_III.Data.Context;
using TP_Programación_III.Entities;

namespace TP_Programación_III.Repository
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
        public IEnumerable<Product> GetProductsOnSale()
        {
            return _context.Products.Where(p => p.OnSale).ToList();
        }

        public IEnumerable<Product> GetProductByName(string name)
        {
            name = name.ToLower();
            return _context.Products.Where(p => p.Name.ToLower().Contains(name)).ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.OrderBy(p => p.Name).ToList(); 
        }
    }
}
