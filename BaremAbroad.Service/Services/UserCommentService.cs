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
    public class UserCommentService : IUserCommentService
    {
        private readonly IGenericRepository<UserComment> _genericRepository;
        private readonly IGenericRepository<BlogArticle> _blogArticleRepository;

        public UserCommentService(IGenericRepository<UserComment> genericRepository, IGenericRepository<BlogArticle> blogArticleRepository)
        {
            _genericRepository = genericRepository;
            _blogArticleRepository = blogArticleRepository;
        }

        public async Task<UserComment> AddUserCommentAsync(UserComment userComment)
        {
            await _genericRepository.AddAsync(userComment);
            return userComment;
        }

        public async Task<List<UserComment>> GetAllArticleCommentsAsync(int articleId)
        {
            var articleComments = await _blogArticleRepository.GetByIdAsync(articleId);
            return articleComments.UserComments.ToList();
        }

        public async Task<List<UserComment>> GetAllUserCommentsAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<UserComment> GetUserCommentByIdAsync(int userId)
        {
            return await _genericRepository.GetByIdAsync(userId);
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
