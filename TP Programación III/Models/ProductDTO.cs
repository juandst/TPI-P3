using System.ComponentModel.DataAnnotations;
using TP_Programación_III.Enums;

namespace TP_Programación_III.Models
{
    public class ProductDTO
    {
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(300)]
        public string Description { get; set; }

        public Category ProductCategory { get; set; }

        public int Price { get; set; }

        public bool HasDiscount { get; set; }


    }
}
