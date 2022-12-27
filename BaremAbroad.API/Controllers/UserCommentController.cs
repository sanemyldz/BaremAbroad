using BaremAbroad.Core.Services;
using BaremAbroad.Repository.DTOs;
using BaremAbroad.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentController : Controller
    {
        private readonly IUserCommentService _userCommentService;

        public UserCommentController(IUserCommentService userCommentService)
        {
            _userCommentService = userCommentService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserCommentByIdAsync(int userId)
        {
            return Ok(await _userCommentService.GetUserCommentByIdAsync(userId));
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveUserCommentByIdAsync(int Id)
        {
            return Ok(await _userCommentService.RemoveUserCommentByIdAsync(Id));
        }
        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateUserCommentByIdAsync(UserComment userComment)
        {
            await _userCommentService.UpdateUserCommentByIdAsync(userComment);
            return NoContent();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> AddUserCommentAsync(UserCommentDTO userComment)
        {
            return Ok(await _userCommentService.AddUserCommentAsync(userComment));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUserCommentsAsync()
        {
            return Ok(await _userCommentService.GetAllUserCommentsAsync());
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllArticleCommentsAsync(int articleId)
        {
            return Ok(await _userCommentService.GetAllArticleCommentsAsync(articleId));
        }
       
    }
}
