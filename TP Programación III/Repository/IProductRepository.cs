using TP_Programación_III.Entities;

namespace TP_Programación_III.Services
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public Product GetProductByName(string name);
    }
}
