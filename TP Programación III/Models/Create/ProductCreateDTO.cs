using System.ComponentModel.DataAnnotations;
using TP_Programación_III.Enums;

namespace TP_Programación_III.Models.Create
{
    public class ProductCreateDTO
    {
        [MaxLength(50, ErrorMessage = "Nombre muy largo")]
        [MinLength(5, ErrorMessage="Nombre muy corto")]
        [Required(ErrorMessage = "Agregá un nombre")]
        public string Name { get; set; }

        [MaxLength(300, ErrorMessage ="Descripción muy larga")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Agregá una categoria")]
        [Range(0, 3)]
        public Category ProductCategory { get; set; }

        [Required(ErrorMessage = "Agregá un precio")]
        [Range(1, int.MaxValue, ErrorMessage = "Precio inválido")]
        public int Price { get; set; }
        [Required]
        public bool HasDiscount { get; set; }

    }
}
