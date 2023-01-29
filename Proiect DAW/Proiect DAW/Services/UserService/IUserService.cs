using DAL.Models;
using DAL.Models.DTOs;
using DAL.Models.DTOs.Users;

namespace Proiect_DAW.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        User GetById(Guid id);
        Task Create(User newUser);
        UserResponseDto Authentificate(UserRequestDto model);
    }
}
