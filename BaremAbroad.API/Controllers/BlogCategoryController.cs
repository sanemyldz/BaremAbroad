using BaremAbroad.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoryController : Controller
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public BlogCategoryController(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBlogCategoryByIdAsync(int Id)
        {
            return Ok(await _blogCategoryService.GetBlogCategoryByIdAsync(Id));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllBlogCategoriesAsync()
        {
            return Ok(await _blogCategoryService.GetAllBlogCategoriesAsync());
        }
    }
}
