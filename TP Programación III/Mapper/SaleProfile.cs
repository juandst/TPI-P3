using AutoMapper;
using TP_Programación_III.Entities;
using TP_Programación_III.Models;

namespace TP_Programación_III.Mapper
{
    public class SaleProfile : Profile
    {
        public SaleProfile()
        {
            CreateMap<Sale, SaleDTO>();
        }
    }
}
