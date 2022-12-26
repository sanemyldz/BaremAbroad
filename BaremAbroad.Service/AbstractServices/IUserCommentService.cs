using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IUserCommentService
    {
        Task<UserComment> GetUserCommentByIdAsync(int userId);
        Task<UserComment> RemoveUserCommentByIdAsync(int Id);
        Task<UserComment> UpdateUserCommentByIdAsync(UserComment userComment);
        Task<UserComment> AddUserCommentAsync(UserComment userComment);
        Task<List<UserComment>> GetAllUserCommentsAsync();
        Task<List<UserComment>> GetAllArticleCommentsAsync(int articleId);
    }
}
