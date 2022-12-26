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
        private readonly IGenericRepository<UserComment> _userCommentRepository;

        public UserCommentLogService(IGenericRepository<UserCommentLog> genericRepository, IGenericRepository<UserComment> userCommentRepository)
        {
            _genericRepository = genericRepository;
            _userCommentRepository = userCommentRepository;
        }

        public async Task<UserCommentLog> AddUserCommentLogAsync(UserCommentLog userCommentLog)
        {
            await _genericRepository.AddAsync(userCommentLog);
            return userCommentLog;
        }

        public async Task<List<UserCommentLog>> GetAllUserCommentLogsAsync(int id)
        {
            var userComment = await _userCommentRepository.GetByIdAsync(id);
            return userComment.UserCommentLogs.ToList();
        }

        public async Task<UserCommentLog> GetUserCommentLogByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }
    }
}
