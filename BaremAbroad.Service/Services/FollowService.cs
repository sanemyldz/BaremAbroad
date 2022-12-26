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
            await _genericRepository.AddAsync(follow);
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
