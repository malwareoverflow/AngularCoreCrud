using AngularCoreCrud.Models;
using AngularCoreCrud.Dtos;

using AutoMapper;

namespace AngularCoreCrud.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}