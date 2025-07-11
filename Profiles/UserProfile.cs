using AutoMapperwithDependencyInjection.DTOs;
using AutoMapperwithDependencyInjection.Models;
using AutoMapper;

namespace AutoMapperwithDependencyInjection.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
