using AutoMapper;
using BaremAbroad.Core.Helpers;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.DTOs.User;
using BaremAbroad.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace BaremAbroad.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _genericRepository;
        private readonly IGenericRepository<UserPassword> _passwordRepository;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> genericRepository, IMapper mapper, IGenericRepository<UserPassword> passwordRepository)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
            _passwordRepository = passwordRepository;
        }
        public async Task<UserResponseDTO> AddUserAsync(CreateUserDTO user)
        {
            UserResponseDTO userResponse = new();

            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var res = await _genericRepository.AddAsync(_mapper.Map<User>(CreateUser(user)));
                    userResponse = _mapper.Map<UserResponseDTO>(res);

                    scope.Complete();
                }
                catch (Exception)
                {
                    scope.Dispose();
                }
            }

            return userResponse;
        }

        public async Task<List<UserResponseDTO>> GetAllUsersAsync()
        {
            return _mapper.Map<List<UserResponseDTO>>(_genericRepository.GetAll().ToList());
        }

        public async Task<UserResponseDTO> GetUserByIdAsync(int userId)
        {
            return _mapper.Map<UserResponseDTO>(await _genericRepository.GetByIdAsync(userId));
        }

        public async Task<bool> LoginCheckAsync(LoginUserDTO user)
        {
            var userEntity = await _genericRepository.GetAll().FirstOrDefaultAsync(w => w.MailAddress.Equals(user.Email));
            if (userEntity is null) return false;
            PasswordHashHelper.CreatePasswordHash(user.Password,
                out byte[] passwordHash,
                out byte[] passwordSalt);
            var hashedPassword = _passwordRepository.GetAll().FirstOrDefaultAsync(w => w.PasswordSalt.Equals(passwordSalt) && w.HashedPassword.Equals(passwordHash) && w.UserId.Equals(userEntity.Id));
            return hashedPassword is null ? false : true;
        }

        public async Task RemoveUserByIdAsync(int userId)
        {
            var user = await _genericRepository.GetByIdAsync(userId);
            _genericRepository.Remove(user);
        }

        public async Task<UserResponseDTO> UpdateUserByIdAsync(UpdateUserDTO user)
        {
            _genericRepository.Update(_mapper.Map<User>(user));
            return _mapper.Map<UserResponseDTO>(await GetUserByIdAsync(user.Id));
        }
        private bool IsValidPassword(string password, string passwordConfirm)
        {
            return string.Equals(password, passwordConfirm);
        }
        private User CreateUser(CreateUserDTO userDTO)
        {
            if (!IsValidPassword(userDTO.Password, userDTO.PasswordConfirm))
            {
                throw new Exception();
            }
            PasswordHashHelper.CreatePasswordHash(userDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);
            userDTO.UserPassword = new Repository.DTOs.UserPasswordDTO()
            {
                HashedPassword = passwordHash.ToString(),
                PasswordSalt = passwordSalt.ToString()
            };
            return _mapper.Map<User>(userDTO);
        }
    }
}
