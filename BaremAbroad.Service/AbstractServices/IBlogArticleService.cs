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
        Task<BlogArticle> UpdateBlogArticleByIdAsync(BlogArticle blogArticle);
        Task<BlogArticle> AddBlogArticleAsync(BlogArticle blogArticle);
        Task<List<BlogArticle>> GetAllBlogArticlesAsync();
    }
}
