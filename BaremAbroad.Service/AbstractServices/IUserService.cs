using BaremAbroad.Repository.DTOs.User;

namespace BaremAbroad.Core.Services
{
    public interface IUserService
    {
        Task<UserResponseDTO> GetUserByIdAsync(int userId);
        Task RemoveUserByIdAsync(int userId);
        Task<UserResponseDTO> UpdateUserByIdAsync(UpdateUserDTO user);
        Task<UserResponseDTO> AddUserAsync(CreateUserDTO user);
        [Obsolete]
        Task<bool> LoginCheckAsync(LoginUserDTO user);
        Task<List<UserResponseDTO>> GetAllUsersAsync();
    }
}
