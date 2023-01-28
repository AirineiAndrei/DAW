using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;
using DAL.Repositories.IngredientRepository;
using DAL.Repositories.UserRepository;
using Microsoft.AspNetCore.Mvc;

namespace Proiect_DAW.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet("all")]
        public Task<List<User>> GetAllUsers()
        {
            return _userRepository.GetAll();
        }
    }
}
