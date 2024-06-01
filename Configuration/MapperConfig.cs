using AutoMapper;
using UserMvcApp.Data;
using System.Configuration;
using UserMvcApp.DTO;

namespace UserMvcApp.Configuration
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<User,UserSignUpDTO>().ReverseMap();
        }
    }
}
