using BaremAbroad.Repository.DTOs.BlogArticle;

namespace BaremAbroad.Core.Services
{
    public interface IBlogArticleService
    {
        Task<BlogArticleResponseDTO> GetBlogArticleByIdAsync(int Id);
        Task RemoveBlogArticleByIdAsync(int Id);
        Task<BlogArticleResponseDTO> UpdateBlogArticleAsync(UpdateBlogArticleDTO blogArticle);
        Task<BlogArticleResponseDTO> AddBlogArticleAsync(CreateBlogArticleDTO blogArticle);
        Task<List<BlogArticleResponseDTO>> GetAllBlogArticlesAsync();
        Task IncreaseUpvote(int articleId);
        Task IncreaseDownVote(int articleId);
    }
}
