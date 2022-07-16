using TP_Programación_III.Entities;

namespace TP_Programación_III.Repository
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProductById(int id);
        public IEnumerable<Product> GetProductByName(string name);
        public IEnumerable<Product> GetProductsOnSale();
    }
}
