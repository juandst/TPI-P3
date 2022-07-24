using AutoMapper;
using TP_Programación_III.Entities;
using TP_Programación_III.Models;
using TP_Programación_III.Models.Create;

namespace TP_Programación_III.Mapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
