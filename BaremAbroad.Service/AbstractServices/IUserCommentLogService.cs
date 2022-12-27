using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IUserCommentLogService
    {
        Task<List<UserCommentLog>> GetUserCommentLogByIdAsync(int commentId);
        Task<UserCommentLog> AddUserCommentLogAsync(UserCommentLog userCommentLog);
        Task<List<UserCommentLog>> GetAllUserCommentLogsAsync();
    }
}
