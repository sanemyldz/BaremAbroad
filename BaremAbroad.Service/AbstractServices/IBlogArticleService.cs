using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaremAbroad.Core.Services
{
    public interface IBlogArticleService
    {
        Task<BlogArticle> GetBlogArticleByIdAsync(int Id);
        Task<BlogArticle> RemoveBlogArticleByIdAsync(int Id);
        Task<BlogArticle> UpdateBlogArticleAsync(BlogArticle blogArticle);
        Task<BlogArticleDTO> AddBlogArticleAsync(BlogArticleDTO blogArticle);
        Task<List<BlogArticle>> GetAllBlogArticlesAsync();
        Task IncreaseUpvote(int articleId);
        Task IncreaseDownVote(int articleId);
    }
}
