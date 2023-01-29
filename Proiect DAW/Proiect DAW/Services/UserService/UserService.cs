using AutoMapper;
using DAL.Models;
using DAL.Models.DTOs;
using DAL.Models.DTOs.Users;
using DAL.Repositories.IngredientRepository;
using DAL.Repositories.UserRepository;
using Microsoft.AspNetCore.Mvc;
using Proiect_DAW.Helpers.Jwt;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Proiect_DAW.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        private IJwtUtils _jwtUtils;
        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
        }

        [HttpGet("all")]
        public Task<List<User>> GetAllUsers()
        {
            return _userRepository.GetAll();
        }
        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }
        public async Task Create(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public UserResponseDto Authentificate(UserRequestDto model)
        {
            var user = _userRepository.FindByUsername(model.UserName);
            if (user == null || !BCryptNet.Verify(model.Password, user.PasswordHash))
            {
                return null; //or throw exception
            }


            // jwt generation
            var jwtToken = _jwtUtils.GenerateJwtToken(user);
            var response = new UserResponseDto(user, jwtToken);

            return response;
        }
    }
}
