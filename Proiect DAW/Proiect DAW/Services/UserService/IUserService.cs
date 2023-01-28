using DAL.Models;
using DAL.Models.DTOs;

namespace Proiect_DAW.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
    }
}
