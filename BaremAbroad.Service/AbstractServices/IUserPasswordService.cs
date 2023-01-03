using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Core.Services
{
    public interface IUserPasswordService
    {
        Task<UserPassword> GetUserPasswordByIdAsync(int userId);
        Task<UserPassword> UpdateUserPasswordAsync(UserPassword userPassword);
    }
}
