using BaremAbroad.Core.Services;
using BaremAbroad.Repository.AbstractRepositories;
using BaremAbroad.Repository.Entities;
using BaremAbroad.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogArticleController : Controller
    {
        private readonly IBlogArticleService _blogArticleService;

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBlogArticleByIdAsync(int Id)
        {
            return Ok(await _blogArticleService.GetBlogArticleByIdAsync(Id));
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveBlogArticleByIdAsync(int Id)
        {
            return Ok(await _blogArticleService.RemoveBlogArticleByIdAsync(Id));
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateBlogArticleAsync(BlogArticle blogArticle)
        {
            await _blogArticleService.UpdateBlogArticleAsync(blogArticle);
            return NoContent();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddBlogArticleAsync(BlogArticle blogArticle)
        {
            return Ok(await _blogArticleService.AddBlogArticleAsync(blogArticle));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllBlogArticlesAsync()
        {
            return Ok(await _blogArticleService.GetAllBlogArticlesAsync());
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> IncreaseUpvote(int articleId)
        {
            await _blogArticleService.IncreaseUpvote(articleId);
            return NoContent();
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> IncreaseDownVote(int articleId)
        {
            await _blogArticleService.IncreaseDownVote(articleId);
            return NoContent();
        }
    }
}