using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Entities;
using System.Transactions;

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
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    await _genericRepository.AddAsync(userCommentLog);
                    scope.Complete();

                }
                catch (Exception)
                {
                    scope.Dispose();
                }
                return userCommentLog;
            }
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
