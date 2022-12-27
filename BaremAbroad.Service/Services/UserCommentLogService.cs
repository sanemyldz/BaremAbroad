using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class UserCommentLogService : IUserCommentLogService
    {
        private readonly IGenericRepository<UserCommentLog> _genericRepository;

        public UserCommentLogService(IGenericRepository<UserCommentLog> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<UserCommentLog> AddUserCommentLogAsync(UserCommentLog userCommentLog)
        {
            await _genericRepository.AddAsync(userCommentLog);
            return userCommentLog;
        }

        public async Task<List<UserCommentLog>> GetAllUserCommentLogsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<List<UserCommentLog>> GetUserCommentLogByIdAsync(int commentId)
        {
            return _genericRepository.GetAll().Where(x => x.UserCommentId.Equals(commentId)).ToList();
        }
    }
}
