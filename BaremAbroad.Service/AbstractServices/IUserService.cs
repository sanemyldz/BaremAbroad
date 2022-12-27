using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int userId);
        Task<User> RemoveUserByIdAsync(int userId);
        Task<User> UpdateUserByIdAsync(User user);
        Task<UserDTO> AddUserAsync(UserDTO user);
        Task<List<User>> GetAllUsersAsync();
    }
}
