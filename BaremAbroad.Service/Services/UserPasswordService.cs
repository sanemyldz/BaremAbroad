using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class UserPasswordService : IUserPasswordService
    {
        private readonly IGenericRepository<UserPassword> _genericRepository;
        private readonly IGenericRepository<User> _userRepository;

        public UserPasswordService(IGenericRepository<UserPassword> genericRepository, IGenericRepository<User> userRepository)
        {
            _genericRepository = genericRepository;
            _userRepository = userRepository;
        }

        public async Task<UserPassword> GetUserPasswordByIdAsync(int userId)
        {
            var user= await _userRepository.GetByIdAsync(userId);
            return user.UserPassword;
        }

        public async Task<UserPassword> UpdateUserPasswordAsync(UserPassword userPassword)
        {
            _genericRepository.Update(userPassword);
            return userPassword;
        }
    }
}
