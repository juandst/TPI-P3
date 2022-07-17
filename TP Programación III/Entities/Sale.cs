using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TP_Programación_III.Enums;

namespace TP_Programación_III.Entities
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public PaymentType PaymentType { get; set; }
        public string ShippingPlace { get; set; }
        [Required]
        public string Name { get; set; }
        public Category ProductCategory { get; set; }
        [Required]
        public int Price { get; set; }

    }
}
