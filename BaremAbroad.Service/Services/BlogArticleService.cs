using AutoMapper;
using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.DTOs.BlogArticle;
using BaremAbroad.Repository.Entities;
using System.Transactions;

namespace BaremAbroad.Service.Services
{
    public class BlogArticleService : IBlogArticleService
    {
        private readonly IGenericRepository<BlogArticle> _genericRepository;
        private readonly IMapper _mapper;
        public BlogArticleService(IGenericRepository<BlogArticle> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<BlogArticleResponseDTO> AddBlogArticleAsync(CreateBlogArticleDTO blogArticleDTO)
        {
            BlogArticleResponseDTO article = new();
            using (TransactionScope scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    article = _mapper.Map<BlogArticleResponseDTO>(await _genericRepository.AddAsync(_mapper.Map<BlogArticle>(blogArticleDTO)));

                    scope.Complete();

                }
                catch (Exception)
                {
                    scope.Dispose();
                }

            }
            return article;
        }

        public async Task<List<BlogArticleResponseDTO>> GetAllBlogArticlesAsync()
        {
            return _mapper.Map<List<BlogArticleResponseDTO>>(_genericRepository.GetAll().ToList());
        }

        public async Task<BlogArticleResponseDTO> GetBlogArticleByIdAsync(int Id)
        {
            return _mapper.Map<BlogArticleResponseDTO>(await _genericRepository.GetByIdAsync(Id));
        }

        public async Task IncreaseDownVote(int articleId)
        {
            var article = await _genericRepository.GetByIdAsync(articleId);
            article.DownVotes += 1;
            await UpdateBlogArticleAsync(_mapper.Map<UpdateBlogArticleDTO>(article));
        }

        public async Task IncreaseUpvote(int articleId)
        {
            var article = await _genericRepository.GetByIdAsync(articleId);
            article.UpVotes += 1;
            await UpdateBlogArticleAsync(_mapper.Map<UpdateBlogArticleDTO>(article));
        }

        public async Task RemoveBlogArticleByIdAsync(int Id)
        {
            var blogArticle = await _genericRepository.GetByIdAsync(Id);
            _genericRepository.Remove(blogArticle);
        }

        public async Task<BlogArticleResponseDTO> UpdateBlogArticleAsync(UpdateBlogArticleDTO blogArticle)
        {
            _genericRepository.Update(_mapper.Map<BlogArticle>(blogArticle));
            return await GetBlogArticleByIdAsync(blogArticle.Id);
        }
    }
}
