using AutoMapper;
using TP_Programación_III.Entities;
using TP_Programación_III.Models;

namespace TP_Programación_III.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
