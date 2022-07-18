using AutoMapper;
using TP_Programación_III.Entities;
using TP_Programación_III.Models;
using TP_Programación_III.Models.Create;
using TP_Programación_III.Models.Update;

namespace TP_Programación_III.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductCreateDTO, Product>();
            CreateMap<ProductUpdateDTO, Product>();
        }
    }
}
