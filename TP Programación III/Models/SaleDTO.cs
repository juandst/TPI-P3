using TP_Programación_III.Enums;

namespace TP_Programación_III.Models
{
    public class SaleDTO
    {
        public int ID { get; set; }
        public PaymentType PaymentType { get; set; }
        public string ShippingPlace { get; set; }
        public string Name { get; set; }
        public Category ProductCategory { get; set; }
        public int Price { get; set; }
    }
}
