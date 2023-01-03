using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Entities;
using System.Transactions;

namespace BaremAbroad.Service.Services
{
    public class FollowService : IFollowService
    {
        private readonly IGenericRepository<Follow> _genericRepository;
        private readonly IGenericRepository<User> _userRepository;
        public FollowService(IGenericRepository<Follow> genericRepository, IGenericRepository<User> userRepository)
        {
            _genericRepository = genericRepository;
            _userRepository = userRepository;
        }
        public async Task<Follow> AddFollowEntryAsync(Follow follow)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    await _genericRepository.AddAsync(follow);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return follow;
        }

        public async Task<List<Follow>> GetAllFollowedAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            return user.Follows.ToList();
        }

        public async Task<List<Follow>> GetAllFollowersAsync(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            return user.Followers.ToList();
        }

        public async Task<Follow> GetFollowByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Follow> RemoveFollowByIdAsync(int id)
        {
            var follow = await _genericRepository.GetByIdAsync(id);
            _genericRepository.Remove(follow);
            return follow;
        }
    }
}
