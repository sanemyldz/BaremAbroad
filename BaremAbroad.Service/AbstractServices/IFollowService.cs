using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Core.Services
{
    public interface IFollowService
    {
        Task<Follow> GetFollowByIdAsync(int id);
        Task<Follow> RemoveFollowByIdAsync(int id);
        Task<Follow> AddFollowEntryAsync(Follow follow);
        Task<List<Follow>> GetAllFollowersAsync(int userId);
        Task<List<Follow>> GetAllFollowedAsync(int userId);
    }
}
