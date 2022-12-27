using AutoMapper;
using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public async Task<UserDTO> AddUserAsync(UserDTO user)
        {
            user.AdminLevel = "User";
            var _user= _mapper.Map<User>(user);
            _user.UserPassword.UserId = _user.Id;
            await _genericRepository.AddAsync(_mapper.Map<User>(user));
            return user;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _genericRepository.GetByIdAsync(userId);
        }

        public async Task<User> RemoveUserByIdAsync(int userId)
        {
            var user = await _genericRepository.GetByIdAsync(userId);
            _genericRepository.Remove(user);
            return user;
        }

        public async Task<User> UpdateUserByIdAsync(User user)
        {
            _genericRepository.Update(user);
            return user;
        }
    }
}
