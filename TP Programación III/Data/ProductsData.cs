using TP_Programación_III.Models;
using TP_Programación_III.Enums;

namespace TP_Programación_III.Data
{
    public class ProductsData
    {
        public List<ProductDTO> Products { get; set; }

        public ProductsData() {
            Products = new List<ProductDTO>();
            {
                new ProductDTO()
                {
                    Id = 1,
                    Name = "PRODUCTO TEST 1",
                    Description = "DESCRIPTION TEST 1",
                    ProductCategory = Category.Accesorios,
                    Price = 100,
                    OnSale = false,
                };
                new ProductDTO()
                {
                    Id = 2,
                    Name = "PRODUCTO TEST 2",
                    Description = "DESCRIPTION TEST 2",
                    ProductCategory = Category.AlimentoGatos,
                    Price = 200,
                    OnSale = true,
                };
            };
        }
    }
}
