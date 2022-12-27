using AutoMapper;
using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using BaremAbroad.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class UserCommentService : IUserCommentService
    {
        private readonly IGenericRepository<UserComment> _genericRepository;
        private readonly IMapper _mapper;


        public UserCommentService(IGenericRepository<UserComment> genericRepository,IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<UserCommentDTO> AddUserCommentAsync(UserCommentDTO userComment)
        {
            await _genericRepository.AddAsync(_mapper.Map<UserComment>(userComment));
            return userComment;
        }

        public async Task<List<UserComment>> GetAllArticleCommentsAsync(int articleId)
        {
            return _genericRepository.GetAll().Where(x => x.BlogArticleId.Equals(articleId)).ToList();
        }

        public async Task<List<UserComment>> GetAllUserCommentsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<List<UserComment>> GetUserCommentByIdAsync(int userId)
        {
            return _genericRepository.GetAll().Where(x => x.UserId.Equals(userId)).ToList();
        }

        public async Task<UserComment> RemoveUserCommentByIdAsync(int Id)
        {
            var userComment = await _genericRepository.GetByIdAsync(Id);
            _genericRepository.Remove(userComment);
            return userComment;
        }

        public async Task<UserComment> UpdateUserCommentByIdAsync(UserComment userComment)
        {
            _genericRepository.Update(userComment);
            return userComment;
        }
    }
}
