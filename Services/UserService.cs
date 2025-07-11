using AutoMapper;
using AutoMapperwithDependencyInjection.DTOs;
using AutoMapperwithDependencyInjection.Models;

namespace AutoMapperwithDependencyInjection.Services
{
    public class UserService
    {
        private readonly IMapper _mapper;

        public UserService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void PrintUserDto(object input)
        {
            // ❌ This line causes ambiguous method call if input is of type object
            // var dto = _mapper.Map<UserDto>(input); // Uncomment to reproduce ambiguity

            // ✅ Correct: cast input or use Map<TSource, TDestination>()
            var user = input as User;
            var dto = _mapper.Map<User, UserDto>(user);

            Console.WriteLine($"DTO: Id={dto.Id}, Name={dto.FullName}");
        }

        //write a method for GetUserDto

        public UserDto GetUserDto(User input)
        {
            var user = input as User;
            var dto = _mapper.Map<User, UserDto>(user);
            return dto;
        }



    }
}
