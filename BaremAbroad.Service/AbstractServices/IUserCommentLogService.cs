using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Core.Services
{
    public interface IUserCommentLogService
    {
        Task<List<UserCommentLog>> GetUserCommentLogByIdAsync(int commentId);
        Task<UserCommentLog> AddUserCommentLogAsync(UserCommentLog userCommentLog);
        Task<List<UserCommentLog>> GetAllUserCommentLogsAsync();
    }
}
