using AutoMapper;
using BaremAbroad.Core.Repositories;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Service.Services
{
    public class BlogArticleService : IBlogArticleService
    {
        private readonly IGenericRepository<BlogArticle> _genericRepository;
        private readonly IMapper _mapper;
        public BlogArticleService(IGenericRepository<BlogArticle> genericRepository,IMapper mapper)        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public async Task<BlogArticleDTO> AddBlogArticleAsync(BlogArticleDTO blogArticleDTO)
        {
            var blogArticle = _mapper.Map<BlogArticle>(blogArticleDTO);

            blogArticle.DownVotes = 0;
            blogArticle.UpVotes = 0;

            await _genericRepository.AddAsync(_mapper.Map<BlogArticle>(blogArticleDTO));

            return blogArticleDTO;
        }

        public async Task<List<BlogArticle>> GetAllBlogArticlesAsync()
        {
            return _genericRepository.GetAll().ToList();
        }

        public async Task<BlogArticle> GetBlogArticleByIdAsync(int Id)
        {
            return await _genericRepository.GetByIdAsync(Id);
        }

        public async Task IncreaseDownVote(int articleId)
        {
            var article = await _genericRepository.GetByIdAsync(articleId);
            article.DownVotes +=1;
            await UpdateBlogArticleAsync(article);
        }

        public async Task IncreaseUpvote(int articleId)
        {
            var article = await _genericRepository.GetByIdAsync(articleId);
            article.UpVotes += 1;
            await UpdateBlogArticleAsync(article);
        }

        public async Task<BlogArticle> RemoveBlogArticleByIdAsync(int Id)
        {
            var blogArticle = await _genericRepository.GetByIdAsync(Id);
            _genericRepository.Remove(blogArticle);
            return blogArticle;
        }

        public async Task<BlogArticle> UpdateBlogArticleAsync(BlogArticle blogArticle)
        {
            _genericRepository.Update(blogArticle);
            return blogArticle;
        }
    }
}
