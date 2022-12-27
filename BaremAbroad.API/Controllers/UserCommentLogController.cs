using BaremAbroad.Core.Services;
using BaremAbroad.Repository.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BaremAbroad.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentLogController : Controller
    {
        private readonly IUserCommentLogService _userCommentLogService;

        public UserCommentLogController(IUserCommentLogService userCommentLogService)
        {
            _userCommentLogService = userCommentLogService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetUserCommentLogByIdAsync(int commentId)
        {
            return Ok(await _userCommentLogService.GetUserCommentLogByIdAsync(commentId));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AddUserCommentLogAsync(UserCommentLog userCommentLog)
        {
            return Ok(await _userCommentLogService.AddUserCommentLogAsync(userCommentLog));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllUserCommentLogsAsync()
        {
            return Ok(await _userCommentLogService.GetAllUserCommentLogsAsync());
        }
    }
}