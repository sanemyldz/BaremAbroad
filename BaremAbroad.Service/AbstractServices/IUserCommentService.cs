using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;

namespace BaremAbroad.Core.Services
{
    public interface IUserCommentService
    {
        Task<List<UserComment>> GetUserCommentByIdAsync(int userId);
        Task<UserComment> RemoveUserCommentByIdAsync(int Id);
        Task<UserComment> UpdateUserCommentByIdAsync(UserComment userComment);
        Task<UserCommentDTO> AddUserCommentAsync(UserCommentDTO userComment);
        Task<List<UserComment>> GetAllUserCommentsAsync();
        Task<List<UserComment>> GetAllArticleCommentsAsync(int articleId);
    }
}
