using BaremAbroad.Core.Services;
using BaremAbroad.Repository.DTOs.BlogArticle;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogArticleController : Controller
    {
        private readonly IBlogArticleService _blogArticleService;

        public BlogArticleController(IBlogArticleService blogArticleService)
        {
            _blogArticleService = blogArticleService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBlogArticleByIdAsync(int Id)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://127.0.0.1:5500");
            return Ok(await _blogArticleService.GetBlogArticleByIdAsync(Id));
        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveBlogArticleByIdAsync(int Id)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://127.0.0.1:5500");
            await _blogArticleService.RemoveBlogArticleByIdAsync(Id);
            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateBlogArticleAsync(UpdateBlogArticleDTO blogArticle)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://127.0.0.1:5500");
            return Ok(await _blogArticleService.UpdateBlogArticleAsync(blogArticle));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddBlogArticleAsync(CreateBlogArticleDTO blogArticle)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://127.0.0.1:5500");
            return Ok(await _blogArticleService.AddBlogArticleAsync(blogArticle));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllBlogArticlesAsync()
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://127.0.0.1:5500");
            return Ok(await _blogArticleService.GetAllBlogArticlesAsync());
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> IncreaseUpvote(int articleId)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://127.0.0.1:5500");
            await _blogArticleService.IncreaseUpvote(articleId);
            return NoContent();
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> IncreaseDownVote(int articleId)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://127.0.0.1:5500");
            await _blogArticleService.IncreaseDownVote(articleId);
            return NoContent();
        }
    }
}